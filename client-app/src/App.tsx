import React, { Component } from 'react';
import './App.css';
import axios from 'axios';
import { Header, Icon, Card } from 'semantic-ui-react';

class App extends Component {
  state = {
    values: []
  }

  componentDidMount() {
    axios.get('http://localhost:5000/api/values')
      .then((rsp) => {
        this.setState({ 
          values: rsp.data
        })
      })   
  }

  render() {
    return (
      <div className="app">
        <Header as='h2'>
          <Icon name='users' />
          <Header.Content>Reactivities</Header.Content>
        </Header>
        <Card.Group>
          { this.state.values.map((val:any) => (
            <Card key={val.id}>
              <Card.Content>
                <Card.Header content={val.name} />
                <Card.Meta content={val.title}  />
              </Card.Content>
            </Card>
          ))}
        </Card.Group>
      </div>
    );
  }
}

export default App;
