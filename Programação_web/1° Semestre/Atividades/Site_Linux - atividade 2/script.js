document.addEventListener("DOMContentLoaded", () => {
    const terminalInput = document.getElementById("terminal-input");
    const terminalOutput = document.getElementById("terminal-output");
    const prompt = document.querySelector(".terminal-prompt");

    // Sistema de arquivos virtual
    const fileSystem = {
        name: "home",
        path: "/home",
        contents: {
            "documentos": {
                name: "Documentos",
                path: "/home/Documentos",
                contents: {
                    "trabalho.txt": "Conteúdo do arquivo de trabalho",
                    "pessoal.docx": "Documentos pessoais importantes"
                }
            },
            "downloads": {
                name: "Downloads",
                path: "/home/Downloads",
                contents: {
                    "setup.exe": "Arquivo de instalação",
                    "imagem.jpg": "Foto de perfil"
                }
            },
            "imagens": {
                name: "Imagens",
                path: "/home/Imagens",
                contents: {}
            },
            "música": {
                name: "Música",
                path: "/home/Música",
                contents: {
                    "playlist1.mp3": "Minha música favorita",
                    "playlist2.mp3": "Música para relaxar"
                }
            },
            "vídeos": {
                name: "Vídeos",
                path: "/home/Vídeos",
                contents: {}
            }
        }
    };

    // Estado do terminal
    let currentDir = fileSystem;
    const rootDir = fileSystem;
    let currentUser = "usuario";

    // Atualiza o prompt com o usuário e caminho atual
    function updatePrompt() {
        const pathSpan = prompt.querySelector(".terminal-path");
        const userSpan = prompt.querySelector(".terminal-user");
        userSpan.textContent = currentUser;
        pathSpan.textContent = getCurrentPath().replace("/home", "~");
    }

    // Retorna o caminho atual
    function getCurrentPath() {
        return currentDir.path;
    }

    // Lista os conteúdos do diretório atual
    function listContents() {
        if (Object.keys(currentDir.contents).length === 0) return "Diretório vazio";
        return Object.keys(currentDir.contents).join("  ");
    }

    // Implementação do comando cd
    function changeDirectory(dirName) {
        if (dirName === "..") {
            if (currentDir !== rootDir) {
                const pathParts = currentDir.path.split("/");
                pathParts.pop();
                const parentPath = pathParts.join("/");
                let parent = rootDir;
                if (parentPath !== "/home") {
                    const pathSegments = parentPath.split("/").slice(2);
                    for (const segment of pathSegments) {
                        parent = parent.contents[segment];
                    }
                }
                currentDir = parent;
                return `Voltou para o diretório ${currentDir.path}`;
            } else {
                return "Já está no diretório raiz";
            }
        }

        if (currentDir.contents[dirName] && typeof currentDir.contents[dirName] === 'object') {
            currentDir = currentDir.contents[dirName];
            return `Diretório alterado para ${currentDir.path}`;
        } else {
            return `cd: ${dirName}: Diretório não encontrado`;
        }
    }

    // Implementação do comando rmdir
    function removeDirectory(dirName) {
        if (!dirName) {
            return "rmdir: falta o nome do diretório";
        }
        
        if (!currentDir.contents[dirName]) {
            return `rmdir: falha ao remover '${dirName}': Diretório não existe`;
        }
        
        if (typeof currentDir.contents[dirName] !== 'object') {
            return `rmdir: falha ao remover '${dirName}': Não é um diretório`;
        }
        
        if (Object.keys(currentDir.contents[dirName].contents).length > 0) {
            return `rmdir: falha ao remover '${dirName}': Diretório não vazio`;
        }
        
        delete currentDir.contents[dirName];
        return `Diretório '${dirName}' removido com sucesso`;
    }

    // Processa todos os comandos digitados
    function processCommand(cmd) {
        if (cmd.trim() === "") return;

        const parts = cmd.trim().split(" ");
        const base = parts[0];
        const args = parts.slice(1);
        let response = "";

        switch (base) {
            case "ls":
                response = listContents();
                break;
            case "pwd":
                response = getCurrentPath();
                break;
            case "whoami":
                response = currentUser;
                break;
            case "clear":
                terminalOutput.innerHTML = "";
                return;
            case "date":
                response = new Date().toString();
                break;
            case "echo":
                response = args.join(" ");
                break;
            case "cd":
                if (args[0]) {
                    response = changeDirectory(args[0]);
                    updatePrompt();
                } else {
                    response = "cd: falta o nome do diretório";
                }
                break;
            case "mkdir":
                if (args[0]) {
                    if (!currentDir.contents[args[0]]) {
                        currentDir.contents[args[0]] = {
                            name: args[0],
                            path: `${currentDir.path}/${args[0]}`,
                            contents: {}
                        };
                        response = `Diretório '${args[0]}' criado em ${currentDir.path}`;
                    } else {
                        response = `mkdir: não é possível criar '${args[0]}': Arquivo existe`;
                    }
                } else {
                    response = "mkdir: falta o nome do diretório";
                }
                break;
            case "rmdir":
                response = removeDirectory(args[0]);
                break;
            case "su":
                if (args.includes("-") || args.includes("-l")) {
                    currentUser = "root";
                    updatePrompt();
                    response = "Autenticação simulada: Agora você é root! (Senha simulada: 1234)";
                } else {
                    response = "Uso: su - ou su -l para login completo";
                }
                break;
            case "sudo":
                if (args.includes("-i")) {
                    currentUser = "root";
                    updatePrompt();
                    response = "Autenticação simulada via sudo: Agora você é root!";
                } else {
                    response = "Uso: sudo -i para login como root";
                }
                break;
            case "exit":
                if (currentUser === "root") {
                    currentUser = "usuario";
                    updatePrompt();
                    response = "Saiu do modo root";
                } else {
                    response = "Sessão encerrada. Até logo!";
                    terminalInput.disabled = true;
                }
                break;
            case "touch":
                if (args[0]) {
                    if (!currentDir.contents[args[0]]) {
                        currentDir.contents[args[0]] = `Arquivo vazio criado em ${new Date().toLocaleString()}`;
                        response = `Arquivo '${args[0]}' criado com sucesso`;
                    } else {
                        response = `touch: não é possível criar '${args[0]}': Arquivo já existe`;
                    }
                } else {
                    response = "touch: falta o nome do arquivo";
                }
                break;
            case "mv":
                if (args.length >= 2) {
                    const source = args[0];
                    const destination = args[1];
                    
                    if (currentDir.contents[source]) {
                        currentDir.contents[destination] = currentDir.contents[source];
                        delete currentDir.contents[source];
                        response = `'${source}' movido para '${destination}'`;
                    } else {
                        response = `mv: não é possível mover '${source}': Não existe`;
                    }
                } else {
                    response = "mv: falta origem e/ou destino";
                }
                break;
            case "cp":
                if (args.length >= 2) {
                    const source = args[0];
                    const destination = args[1];
                    
                    if (currentDir.contents[source]) {
                        currentDir.contents[destination] = currentDir.contents[source];
                        response = `'${source}' copiado para '${destination}'`;
                    } else {
                        response = `cp: não é possível copiar '${source}': Não existe`;
                    }
                } else {
                    response = "cp: falta origem e/ou destino";
                }
                break;
            case "rm":
                if (args[0]) {
                    if (currentDir.contents[args[0]]) {
                        if (typeof currentDir.contents[args[0]] === 'object') {
                            response = `rm: não é possível remover '${args[0]}': É um diretório`;
                        } else {
                            delete currentDir.contents[args[0]];
                            response = `Arquivo '${args[0]}' removido`;
                        }
                    } else {
                        response = `rm: não é possível remover '${args[0]}': Não existe`;
                    }
                } else {
                    response = "rm: falta o nome do arquivo";
                }
                break;
            case "cat":
                if (args[0]) {
                    if (currentDir.contents[args[0]] && typeof currentDir.contents[args[0]] !== 'object') {
                        response = currentDir.contents[args[0]];
                    } else {
                        response = `cat: ${args[0]}: Arquivo não encontrado ou é diretório`;
                    }
                } else {
                    response = "cat: falta o nome do arquivo";
                }
                break;
            case "help":
                response = `Comandos disponíveis:
                    ls        - Lista conteúdo do diretório
                    pwd       - Mostra diretório atual
                    whoami    - Mostra usuário atual
                    clear     - Limpa a tela
                    date      - Mostra data e hora
                    echo      - Repete o texto
                    help      - Mostra esta ajuda
                    mkdir     - Cria diretório
                    rmdir     - Remove diretório vazio
                    cd        - Muda de diretório
                    touch     - Cria arquivo vazio
                    mv        - Move/renomeia arquivos
                    cp        - Copia arquivos
                    rm        - Remove arquivos
                    cat       - Exibe conteúdo de arquivos
                    su -      - Login como root
                    sudo -i   - Login como root via sudo
                    exit      - Sair do root ou terminal`;
                break;
            case "grep":
                if (args.length < 2) {
                    response = "Uso: grep 'padrão' arquivo";
                    break;
                }
                
                const pattern = args[0];
                const filename = args[1];
                
                if (!currentDir.contents[filename] || typeof currentDir.contents[filename] === 'object') {
                    response = `grep: ${filename}: Arquivo não encontrado ou é um diretório`;
                } else {
                    const fileContent = currentDir.contents[filename];
                    if (fileContent.includes(pattern)) {
                        response = fileContent.split('\n')
                            .filter(line => line.includes(pattern))
                            .join('\n');
                    } else {
                        response = `Nenhuma correspondência encontrada para '${pattern}'`;
                    }
                }
                break;

            case "chmod":
                if (args.length < 2) {
                    response = "Uso: chmod permissões arquivo\nExemplo: chmod 644 arquivo.txt";
                    break;
                }
                
                const permissions = args[0];
                const targetFile = args[1];
                
                // Validação simples de permissões (formato numérico)
                if (!/^[0-7]{3}$/.test(permissions)) {
                    response = `chmod: permissões inválidas '${permissions}' (use 3 dígitos de 0-7)`;
                } else if (!currentDir.contents[targetFile]) {
                    response = `chmod: não é possível acessar '${targetFile}': Arquivo não existe`;
                } else if (typeof currentDir.contents[targetFile] === 'object') {
                    response = `chmod: não é possível modificar '${targetFile}': É um diretório`;
                } else {
                    // Simula a alteração de permissões (em um sistema real, isso seria armazenado)
                    response = `Permissões de '${targetFile}' alteradas para ${permissions}`;
                    // Adiciona as permissões simuladas ao arquivo (opcional)
                    if (typeof currentDir.contents[targetFile] === 'string') {
                        currentDir.contents[targetFile] = {
                            content: currentDir.contents[targetFile],
                            permissions: permissions
                        };
                    } else if (typeof currentDir.contents[targetFile] === 'object') {
                        currentDir.contents[targetFile].permissions = permissions;
                    }
                }
                break;
            default:
                response = `Comando não reconhecido: ${cmd}`;
        }

        // Exibe o comando e a resposta formatados
        terminalOutput.innerHTML += `<div class="command-line">
            <span class="prompt-display">
                <span class="terminal-user">${currentUser}</span>
                <span class="terminal-at">@</span>
                <span class="terminal-host">linux</span>:
                <span class="terminal-path">${getCurrentPath().replace("/home", "~")}</span>${currentUser === "root" ? "#" : "$"}
            </span>
            <span class="command-text"> ${cmd}</span>
        </div>
        <div class="response-line">${response}</div>
        <div class="empty-line"></div>`;

        // Rolagem automática
        terminalOutput.scrollTop = terminalOutput.scrollHeight;
    }

    // Captura o Enter para executar comandos
    terminalInput.addEventListener("keydown", (e) => {
        if (e.key === "Enter") {
            const cmd = terminalInput.value;
            processCommand(cmd);
            terminalInput.value = "";
        }
    });
});