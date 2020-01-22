import React, { useState, useEffect } from 'react';
import axios from 'axios';

const AxiosPokemonList = props => {

    const[ pokemon, setPokemon ] = useState ([]);
    // const [ pokeID, setPokeID ] = useState (1);



    const GetPokemons = e => {
        
            axios.get("https://pokeapi.co/api/v2/pokemon/?offset=0&limit=807")
                    .then(response => {
                        setPokemon(response.data.results)
                        console.log(response);
                    })
                    .catch(err => {
                        console.log(err)
                    })

                
    }

    

        // useEffect(()=>{
        //     GetPokemons();
        // }, []);
    







    return (
        <>
            <p>hi</p>
            <button onClick={GetPokemons}>Fetch all da Pokemanz!</button>
            
            <h3>Using axios: List of Pokemon names</h3>
            <ul>
                    
                    {
                        pokemon.map( (poke, index) => 
                            <li key={index}>
                                {poke.name}
                            </li>)
                    }
            </ul>
        </>

        
    )
}

export default AxiosPokemonList;