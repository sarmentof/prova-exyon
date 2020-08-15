import React, { useState } from 'react';
import logo from '../../assets/logo.png';


import api from '../../services/api';

import { Title, Form }  from './styles';

const Dashboard = () => {
  const [novaNotaUsuarioConhecimento, setNovaNotaUsuarioConhecimento] = useState('')
  const [buscaNotasUsuario, setBNA] = useState([])
  const [buscaAssuntos, setAssuntos] = useState([])

  // const [buscaAssuntos, setAssuntos] = useState(() => {
  //   const storageAssuntos = localStorage.getItem('@MatrizConhecimento:login');

  //   if (storageAssuntos) {
  //     return JSON.parse(storageAssuntos)
  //   } else {
  //      return []
  //    }
  // })

  // useEffect(() => {
  //   localStorage.setItem('@MatrizConhecimento:login', JSON.stringify(login))
  // }, [])

  async function handleBuscaNotasUsuario(event) {
    event.preventDefault();
    // Pesquisa nota por ID (Mudar para Conhecimento)
    // const response = await api.get(`notasusuariosassuntos/{id}`).then(res => console.log(res.data))

    const responseBNA = await api.get('notasusuariosassuntos')
    const resBNA = responseBNA.data
    setBNA([resBNA])
    console.log('BNA >>', buscaNotasUsuario)

    const responseAssuntos = await api.get('assuntos')
    const resA = responseAssuntos.data
    setAssuntos([resA])
    console.log('BA >>', buscaAssuntos)



  }


  return (
    <>
      <img src={logo} alt="Matriz de Conhecimentos"/>     Fabiano Sarmento
      <Title>Dashboard - Conhecimentos</Title>

      <Form onSubmit={handleBuscaNotasUsuario}>
        <input
          value={novaNotaUsuarioConhecimento}
          onChange={(e) => setNovaNotaUsuarioConhecimento(e.target.value)}
          placeholder="Buscar Conhecimento"/>
        <button type="submit">Buscar</button>
      </Form>

      {/* {buscaNotasUsuario.map((u) => { <div key={u.idNotaUsuarioAssunto}>u.</div> })} */}
    </>
  )
};

export default Dashboard;
