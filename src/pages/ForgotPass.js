import { Button, TextInput } from '@mantine/core';
import { React } from 'react';
import { Helmet } from 'react-helmet';

export default function ForgotPass() {
  function handleSubmit(e) {
    e.preventDefault();
    console.log(e.target);
  }

  return (
    <>
      <Helmet>
        <meta charset='UTF-8' />
        <meta http-equiv='X-UA-Compatible' content='IE=edge' />
        <meta name='viewport' content='width=device-width, initial-scale=1.0' />
        <title>Age Verification | Forgot Password</title>
      </Helmet>

      <main className='flex flex-col translate-y-1/4 m-4'>
        <h1 className='text-6xl flex flex-col justify-center'>
          Forgot Password
        </h1>
        <h2 className='text-base align-text-top flex flex-col justify-center'>
          Please enter your email address
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
              onClick={(e) => handleSubmit(e)}
            >
              Next
            </Button>
          </div>
        </form>
      </main>
    </>
  );
}