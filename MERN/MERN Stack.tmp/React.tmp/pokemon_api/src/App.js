import React from 'react';
import './App.css';
import PokemonList from './Components/PokemonAPI'
import AxiosPokemonAPI from './Components/AxiosPokemonAPI'

function App() {
  return (
    <div>

    {/* <PokemonList /> */}
    <AxiosPokemonAPI />
      
    </div>
  );
}

export default App;
