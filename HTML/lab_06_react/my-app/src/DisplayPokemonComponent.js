import React from 'react'
import Pokemon from './PokemonComponent'

const DisplayPokemonComponent = (props) => {

    return (
        <div>
            {props.pokemons.map((pokemon, index) => <Pokemon key={index} pokemon={pokemon} changeSelectedPoke={ props.changeSelectedPoke} />)}
        </div>
    )

}

export default DisplayPokemonComponent