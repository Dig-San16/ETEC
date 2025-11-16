//Prof. Alexandre Garcez Vieira
//
//
import 'package:flutter/material.dart';

void main() {
  runApp(const MinhasTarefasApp());
}

class MinhasTarefasApp extends StatelessWidget {
  const MinhasTarefasApp({super.key});

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      debugShowCheckedModeBanner: false,
      title: 'Minhas Tarefas',
      theme: ThemeData(
        primarySwatch: Colors.indigo,
        useMaterial3: true,
      ),
      home: const TelaPrincipalTarefas(),
    );
  }
}

class TelaPrincipalTarefas extends StatefulWidget {
  const TelaPrincipalTarefas({super.key});

  @override
  State<TelaPrincipalTarefas> createState() => _TelaPrincipalTarefasState();
}

class _TelaPrincipalTarefasState extends State<TelaPrincipalTarefas> {
  
  final List<String> _listaDeTarefas = [];
  final TextEditingController _controladorTexto = TextEditingController();

  void _adicionarTarefa() {
    if (_controladorTexto.text.isNotEmpty) {
      setState(() {
        _listaDeTarefas.add(_controladorTexto.text);
      });
      _controladorTexto.clear();
    }
  }

  // NOVA FUNÇÃO
  // 3. A "Ação" para REMOVER
  void _removerTarefa(int index) {
    setState(() {
      _listaDeTarefas.removeAt(index);
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text('Minhas Tarefas'),
        backgroundColor: Theme.of(context).colorScheme.inversePrimary,
      ),
      body: Padding(
        padding: const EdgeInsets.all(16.0),
        child: Column(
          children: [
            Row(
              children: [
                Expanded(
                  child: TextField(
                    controller: _controladorTexto,
                    decoration: const InputDecoration(
                      labelText: 'Qual a próxima tarefa?',
                    ),
                  ),
                ),
                const SizedBox(width: 8),
                ElevatedButton(
                  onPressed: _adicionarTarefa,
                  child: const Text('Adicionar'),
                ),
              ],
            ),
            const SizedBox(height: 20),
            
            Expanded(
              child: ListView.builder(
                itemCount: _listaDeTarefas.length,
                itemBuilder: (context, index) {
                  final tarefa = _listaDeTarefas[index];
                  
                  // LISTTILE ATUALIZADO
                  return ListTile(
                    title: Text(tarefa),
                    
                    // NOVO! Adicionando o ícone de lixeira
                    trailing: IconButton(
                      icon: const Icon(Icons.delete),
                      color: Colors.red,
                      
                      // Ação ao clicar no ícone
                      onPressed: () {
                        // Chama nossa função de remover!
                        _removerTarefa(index); 
                      },
                    ),
                  );
                },
              ),
            ),
          ],
        ),
      ),
    );
  }
}