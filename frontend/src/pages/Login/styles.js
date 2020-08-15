import styled from 'styled-components'

import { shade } from 'polished'

export const Title = styled.h1`
  font-size: 48px;
  color: #3A3A3A;

  margin-top: 10px;
`;

export const Form = styled.form`
  margin-top: 300px;
  margin-left: 30px;
  max-width: 700px;


  input{
    height: 45px;
    padding: 0 24px;
    border: 0;
    border-radius: 5px 5px 5px 5px;
    margin-top: 10px;

    &::placeholder {
      color: #a8a8b3;
    }
  }

  button {
    width: 230px;
    height: 45px;
    background: #04d361;
    border: 0;
    border-radius: 5px 0px 5px 0px;
    color: #FFF;
    font-weight: bold;
    transition: background-color 0.2s;
    align-items: center;
    margin-top: 30px;

    &:hover {
      background: ${shade(0.2, '#04d361')}
    }
  }
`;
