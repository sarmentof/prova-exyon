import axios from 'axios';

const api = axios.create({
  baseURL: 'https://localhost:44342/api',
});

export default api;