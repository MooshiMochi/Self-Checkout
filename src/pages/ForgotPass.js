import { Button, TextInput } from "@mantine/core";
import { React } from "react";
import { Helmet } from "react-helmet";

export default function ForgotPass() {
  return (
    <>
      <Helmet>
        <meta charset='UTF-8' />
        <meta http-equiv='X-UA-Compatible' content='IE=edge' />
        <meta name='viewport' content='width=device-width, initial-scale=1.0' />
        <title>Age Verification | Forgot Password</title>
      </Helmet>

      <main className='flex flex-col '>
        <h1 className='text-3xl text-center flex flex-col justify-center -translate-y-10'>
          Forgot Password
        </h1>
        <h2 className='text-base align-text-top flex flex-col justify-center'>
          Please enter your email address
        </h2>

        <form className='flex flex-col justify-center items-center -translate-y-24'>
          <TextInput
            type='email'
            name='email'
            id='email'
            placeholder='Enter your email'
            className='lg:w-2/3 w-full m-auto py-2'
          />
          <Button
            type='submit'
            variant='outline'
            color='green'
            className='w-full m-auto'
          >
            Next
          </Button>
        </form>
      </main>
    </>
  );
}
