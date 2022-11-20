import { Route, Routes } from 'react-router-dom';
import './App.css';
import ForgotPass from './pages/ForgotPass';
import Home from './pages/Home';
import Login from './pages/Login';
import Profile from './pages/Profile';
import Signup from './pages/Signup';

function App() {
  return (
    <Routes>
      <Route path='/' element={<Home />} />
      <Route path='/home' element={<Home />} />
      <Route path='/login' element={<Login />} />
      <Route path='/signup' element={<Signup />} />
      <Route path='/profile' element={<Profile />} />
      <Route path='/forgot-password' element={<ForgotPass />} />
    </Routes>
  );
}

export default App;
