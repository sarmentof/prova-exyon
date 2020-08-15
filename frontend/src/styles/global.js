import { createGlobalStyle  } from 'styled-components';

import bgGraph from '../assets/bgGraph.svg';

export default createGlobalStyle`
  *{
    margin: 0;
    padding: 0;
    box-sizing: border-box;
  }

  body {
    background: #F0F0F5 url(${bgGraph}) no-repeat 9% -110%;
    -webkit-font-smoothing: antialiased;
  }

  body, input, button {
    font: 16px 'Roboto', sans-serif;
  }

  #root {
    max-width: 960px;
    margin: 0 auto;
    padding: 15px 70px;
  }

  button {
    cursor: pointer;
  }
`;
