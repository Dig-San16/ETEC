import React, { useState } from "react";
import { StyleSheet, Text, TextInput, View } from "react-native";

export default function Home() {
    const [name, setName] = useState(''); //useState do nome.

    const [name1, setName1] = useState(''); //useState do segundo nome.
    return (
        <View style={styles.body}>
            <TextInput placeholder="Digite seu primeiro nome" onChangeText={setName}/>
            <Text style={styles.title}>Primeiro campo de texto {name}</Text>
            
            <TextInput placeholder="Digite qualquer coisa" onChangeText={setName1}/> 
            <Text style={styles.title}>Segundo campo de texto {name1}</Text>
        </View>
    );
}

const styles = StyleSheet.create({
    body: {
        backgroundColor: "blue", 
        padding: "auto"
    },
    title: {
        fontSize: 19
    }
})