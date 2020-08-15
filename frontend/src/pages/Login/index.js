import React, { Component } from 'react'
import { Title, Form }  from './styles';

import Dashboard from '../Dashboard';


class Login extends Component {

  handleSubmit = (e) => {
    e.preventDefault();
    const username = e.target.elements.username.value;
    localStorage.setItem('@matriz-conhecimento/username', username);
    window.location.reload();
  }

  handleLogout = () => {
    localStorage.removeItem('@matriz-conhecimento/username');
    window.location.reload();
  }

  render() {
    const username = localStorage.getItem('@matriz-conhecimento/username');
    if (username !== null) {
      return (
        <>
        <Dashboard />
        </>
      );

    }
    return (
      <>
      <Form onSubmit={this.handleSubmit}>
        <input type="text" name="username" placeholder="Nome de usuário" required />
        <br/>
        <input type="password" name="password" placeholder="Sua senha" required />
        <br />
        <button type="submit" >Entrar</button>
      </Form>
      </>
    );
  }
}

const styles = {
  container: {
    display: 'flex',
    textAlign: 'center',
    flexDirection: 'column',
    width: '100px',
    minWidth: '300px',
    maxWidth: '600px',
    boxShadow: 'rgba(0, 0, 0, 0.1) 0px 0px 20px',
    background: 'rgb(255, 255, 255)',
    borderRadius: '4px',
    padding: '30px 20px',
    margin: '0 auto',
    marginTop: '300px'
  },
  submitButton: {
    height: '40px',
    textAlign: 'center',
    alignItems: 'center',
    borderRadius: '4px',
    fontWeight: 'bold',
    fontSize: '14px',
    border: 0,
    color: '#fff',
    background: '#04d361',
    marginTop: '5px',
  },
  username: {
    height: '40px',
    padding: '0 15px',
    border: '1px solid #eee',
    borderRadius: '4px',
    marginBottom: '10px',
    color: '#444'
  },
  password: {
    height: '40px',
    padding: '0 15px',
    border: '1px solid #eee',
    borderRadius: '4px',
    marginBottom: '10px',
    color: '#444'
  }
}

export default Login;
