import styled from 'styled-components'

import { shade } from 'polished'

export const Title = styled.h1`
  font-size: 48px;
  color: #3A3A3A;

  margin-top: 10px;
`;

export const Form = styled.form`
  margin-top: 40px;
  max-width: 700px;

  display: flex;

  input{
    flex: 1;
    height: 45px;
    padding: 0 24px;
    border: 0;
    border-radius: 5px 0px 0px 5px;

    &::placeholder {
      color: #a8a8b3;
    }
  }

  button {
    width: 210px;
    height: 45px;
    background: #04d361;
    border: 0;
    border-radius: 0px 5px 5px 0px;
    color: #FFF;
    font-weight: bold;
    transition: background-color 0.2s;

    &:hover {
      background: ${shade(0.2, '#04d361')}
    }
  }
`;
