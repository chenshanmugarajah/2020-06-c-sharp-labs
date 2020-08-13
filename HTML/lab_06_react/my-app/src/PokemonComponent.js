import React from 'react'

// class PokemonComponent extends React.Component {

//     state = {
//         selectedPokemon: []
//     }

//     handleStateChange = (url) => {

//         fetch(url)
//         .then(response => response.json())
//         .then(data => this.setState({ selectedPokemon: data }) )
//     }

//     render () {

//         const { pokemon } = this.props

//         return (
//             <div>
//                 <p>{pokemon.name}</p>
//                 <button onClick={ () => this.handleStateChange(pokemon.url) } > GET DATA </button>
//             </div>
//         )
//     }
        
// }

const Pokemon = (prop) => {

    return (
        <div>
            <p>{prop.pokemon.name}</p>
            <button onClick={ () => prop.changeSelectedPoke(prop.pokemon.url) } > get pokemon data </button>
        </div>
    )
}

export default Pokemon