import React from 'react';
import { Helmet } from 'react-helmet';
import { useNavigate } from 'react-router-dom';

const Home = () => {
  const navigate = useNavigate();

  const buttonClassName =
    'min-w-14 md:min-w-20 lg:min-w-36 py-1 px-0 inline-block text-xs text-center rounded-md';

  async function handleLogin(e) {
    e.preventDefault();
  }

  async function handleRegister(e) {
    e.preventDefault();
  }

  async function handleForgotPassword() {}

  return (
    <>
      <Helmet>
        <meta charset='UTF-8' />
        <meta http-equiv='X-UA-Compatible' content='IE=edge' />
        <meta name='viewport' content='width=device-width, initial-scale=1.0' />
        <title>Age Verification | Home</title>
      </Helmet>
      <main className='flex flex-col justify-center items-center h-screen m-auto fixed top-1/2 left-1/2 -translate-y-1/2 -translate-x-1/2 text-center'>
        <div className=''>
          <h1 className='text-lg md:text-2xl lg:text-4xl'>Age Verification</h1>
          <div className='main-div'>
            <div className='flex space-x-3'>
              <button
                className={`${buttonClassName}`}
                onClick={(e) => handleLogin(e)}
              >
                Login
              </button>
              <button
                className={`${buttonClassName}`}
                onClick={(e) => handleRegister(e)}
              >
                Sign up
              </button>
            </div>
            <div className='text-sm md:text-lg'>
              <a href='#/'>
                <i>Forgot password</i>
              </a>
            </div>
          </div>
        </div>
      </main>
    </>
  );
};

export default Home;
