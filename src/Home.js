import React from 'react';
import { Helmet } from 'react-helmet';

const Home = () => {
  return (
    <>
      <Helmet>
        <meta charset='UTF-8' />
        <meta http-equiv='X-UA-Compatible' content='IE=edge' />
        <meta name='viewport' content='width=device-width, initial-scale=1.0' />
        <meta property='og:image' content='/logo.svg' />
        <title>Age Verification | Home</title>
      </Helmet>
      <main>
        <h1 className=''>Age Verification</h1>
        <div className='main-div'>
          <div>
            <button id='btn_login'>Login</button>
            <button id='btn_signup'>Sign up</button>
          </div>
          <div>
            <a href='#/'>
              <i>Forgot password</i>
            </a>
          </div>
        </div>
      </main>
    </>
  );
};

export default Home;