import React, { Component } from 'react'
import Slider from './components/Slider'
import SavedColors from './components/SavedColors'
import ColorBox from './components/ColorBox'

class App extends Component {
  state = {
    h: 120,
    s: 50,
    l: 50,
    a: 50,
    divStyle: '',
    yourColor: []
  }

  updateHslaFromSlider = (event, key) => {
    this.setState({
      [key]: event.target.value
    })
    console.log(this.state[key])
  }

  saveYourColor = () => {
    this.setState({
      yourColor: this.state.yourColor.concat({
        hue: this.state.h,
        saturation: this.state.s,
        lightness: this.state.l,
        alpha: this.state.a
      })
    })
  }
  render() {
    return (
      <section className="allmycontents">
        <h1 className="title"> Pick My Color💕</h1>
        <main className="contents">
          <ColorBox
            h={this.state.h}
            l={this.state.l}
            s={this.state.s}
            a={this.state.a}
          />
          <SavedColors
            savedColors={this.state.yourColor}
            saveYourColor={this.saveYourColor}
          />
          <section className="hslrange">
            <Slider
              label="H"
              maxValue="240"
              onSlide={event => this.updateHslaFromSlider(event, 'h')}
              sliderValue={this.state.h}
            />
            <Slider
              label="S"
              maxValue="100"
              onSlide={event => this.updateHslaFromSlider(event, 's')}
              sliderValue={this.state.s}
            />
            <Slider
              label="L"
              maxValue="100"
              onSlide={event => this.updateHslaFromSlider(event, 'l')}
              sliderValue={this.state.l}
            />
            <Slider
              label="A"
              maxValue="100"
              onSlide={event => this.updateHslaFromSlider(event, 'a')}
              sliderValue={this.state.a}
            />
          </section>
        </main>
      </section>
    )
  }
}

export default App
