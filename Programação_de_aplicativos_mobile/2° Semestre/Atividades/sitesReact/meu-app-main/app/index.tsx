import { fetchCharacters } from '@/services/list';
import { useEffect, useState } from 'react';
import { FlatList, Image, Text, View } from 'react-native';
interface Personagem {
    id: number;
    name: string;
    images: [string];
}

export default function Home(){
    const [personagens, setPersonagens] = useState<Personagem[]>([]);
     
    useEffect(() => {
        async function carregarPersonagens() {
            const dados = await fetchCharacters();
            setPersonagens(dados.characters);
        }
        
        carregarPersonagens();
}, []);
    return(
        <View>
            <Text>Lista de Personagens</Text>

            <FlatList
                data={personagens}
                keyExtractor={item => item.id.toString()}
                renderItem={({item})=> (
                    <View>
                        <Image source={{uri: item.images[0]}}/>
                        <Text>{item.name}</Text>
                    </View>
                )}
            />
        </View>
    );
}