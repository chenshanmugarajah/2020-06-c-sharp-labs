import React from 'react'

const SelectedPokemon = (props) => {

    return (
        <div>
            <h1>Species: {props.pokemon.species.name }</h1>

            <h3>Info</h3>
            <p>Height: {props.pokemon.height}</p>
            <p>Weight: {props.pokemon.weight} </p>

            <h3>Abilities</h3>
            <div>
    {props.pokemon.abilities.map(abilities => <div> {abilities.ability.name} </div> )}
            </div>
            <button onClick={ () => props.setPokeNull() } >GO BACK</button>
        </div>
    )

}

export default SelectedPokemon