import { Button, TextInput } from '@mantine/core';
import { React, useState } from 'react';
import { Helmet } from 'react-helmet';
import { useNavigate } from 'react-router-dom';

export default function ForgotPass() {
  const navigate = useNavigate();
  const [enterCode, showEnterCode] = useState(false);
  const [passwordReset, setPasswordReset] = useState(false);
  const [clicked, setClicked] = useState(0);
  let page = !passwordReset ? (
    <div>
      <h1 className='text-6xl flex flex-col justify-center'>
        Forgot Password
      </h1>
      <h2 className='text-base align-text-top flex flex-col justify-center'>
        {enterCode ? (
          <div>
            We've found the email ... linked to your account<br></br>
            Please enter the verification code sent
          </div>
        ) : (
          'Please enter your email address'
        )}
      </h2>

      <form className='flex flex-col'>
        <TextInput
          type='email'
          name='email'
          id='email'
          placeholder='Enter your email'
          className='lg:w-1/3 mt-4'
        />
        <div className='lg:w-1/6 lg:h-6'>
          <Button
            type='submit'
            variant='outline'
            color='green'
            className='lg:w-1/2 lg:h-1/12 mt-2 rounded-lg border-4 border-teal-300 shadow-inner shadow-gray-600 text-inherit'
            onClick={() => {
              showEnterCode(true);
              setClicked(clicked + 1);
              clicked == 2 ? setPasswordReset(true) : setPasswordReset(false);
              document.getElementById('email').value = '';
              // clear the input field

              // send email to user

              // show the input field for the code

              // show the button to submit the code

              // show the button to resend the code
            }}
          >
            Next
          </Button>
        </div>
      </form>
    </div>
  ) : (
    <div className='text-center w-full mx-auto'>
      <h1 className='text-6xl'>
        Forgot Password
      </h1>
      <div>Your password has been reset</div>
      <div className='lg:w-1/6 lg:h-6'>
          <Button
            type='submit'
            variant='outline'
            color='green'
            className=' mt-2 rounded-lg border-4 border-teal-300 shadow-inner shadow-gray-600 text-inherit'
            onClick={() => {
              navigate('/login');
            }}
          >
            Next
          </Button>
        </div>
    </div>);

  return (
    <>
      <Helmet>
        <meta charset='UTF-8' />
        <meta http-equiv='X-UA-Compatible' content='IE=edge' />
        <meta name='viewport' content='width=device-width, initial-scale=1.0' />
        <title>Age Verification | Forgot Password</title>
      </Helmet>

      <main className='flex flex-col translate-y-1/4 m-4'>
        {page}
      </main>
    </>
  );
}
