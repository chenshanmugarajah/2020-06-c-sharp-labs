import React from 'react'
import ChildComponent from './ChildComponent'
import ShowComponent from './ShowComponent'
import DisplayPokemonComponent from './DisplayPokemonComponent'
import SelectedPokemon from './SelectedPokemon'

class LikeComponent extends React.Component {

    constructor() {
        super ()
        this.state = {
            likes: 0,
            isShown: false,
            pokemons: [],
            selectedPokemon: null
        }
    }

    handleStateChange = (url) => {

        fetch(url)
        .then(response => response.json())
        .then(data => this.setState({ selectedPokemon: data }) )
    }

    componentDidMount() {
        fetch("https://pokeapi.co/api/v2/pokemon?limit=20")
        .then(response => response.json())
        .then(pokemonsJson => this.setState({pokemons: pokemonsJson.results}))
    }

    incrementLikeCount = () => {
        this.setState({
            likes: this.state.likes + 1
        })
    }

    handleShowChange = () => {
        this.setState({
            isShown: !this.state.isShown
        })
    }

    setSelectedNull = () => {
        this.setState({ selectedPokemon: null })
    }

    render() {
        return (
            <main>
                <div>
                    <h1>This is the amount of likes: {this.state.likes}</h1>
                    <ChildComponent incrementLikeCount={this.incrementLikeCount} />

                    <button onClick={() => this.handleShowChange()}>Show me!</button>

                    { this.state.isShown ? <ShowComponent /> : null }

                    { this.state.selectedPokemon ? <SelectedPokemon setPokeNull={ this.setSelectedNull } pokemon={this.state.selectedPokemon} /> : <DisplayPokemonComponent pokemons={this.state.pokemons} changeSelectedPoke={this.handleStateChange} /> }
                </div>
            </main>
        )
    }
}

export default LikeComponent