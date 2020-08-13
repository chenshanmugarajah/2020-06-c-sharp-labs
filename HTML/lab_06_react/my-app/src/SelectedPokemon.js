import React from 'react'

const SelectedPokemon = (props) => {

    return (
        <div>
            <h1> { props.pokemon.height} </h1>
            <h3>props data</h3>

            <button onClick={ () => props.setPokeNull() } >GO BACK</button>
        </div>
    )

}

export default SelectedPokemon