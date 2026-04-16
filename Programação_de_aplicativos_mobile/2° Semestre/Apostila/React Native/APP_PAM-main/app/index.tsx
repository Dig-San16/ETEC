//ZONA DE IMPORTAÇÂO

//Aqui importamos o react native e uma função
import React, { useState } from "react";
//importamos os elementos do TSX
import { StyleSheet, Text, TextInput, View } from "react-native";

//esta é uma função
export default function Home() {

    //essa constante faz uma atribuição descontruída (isso significa que o useState retorna um array)
    const [name, setName] = useState('');
    const [name2, setName2] = useState('');

    return (
        //dentro deste elemento, há outros elementos responsáveis pela parte visual do site

        //TextInput solicita que o usuário digite algum texto
        //onChangeText le texto dado pelo usuário
        //Text basicamente mostra o texto escrito pelo usuário

        //o STYLE é uma propriedade utilizada para personalização, ali adicionamos 
        //o nome do objeto e o elemento de personalização.
        <View style={styles.body}>
            
            <TextInput 
            placeholder="digite seu nome: "
            onChangeText={setName}
            >
            </TextInput>

            <TextInput
            placeholder="digite outra coisa sla: "
            onChangeText={setName2}
            >
            </TextInput>

            <Text style={styles.title}>
                Olá {name}, este é meu primeiro app
            </Text>

            <Text style={styles.title}>
                Ah sim olha ai: {name2}
            </Text>

        </View>
    );
}

//Aqui localiza-se o objeto STYLES, dentro dele estão os elementos responsáveis por 
//personalizar o site, e serão referenciados nos elementos existentes no return 
const styles = StyleSheet.create({
    body: {
        backgroundColor: "blue",
        padding: "auto"
    },
    title: {
        fontSize: 19
    }
})