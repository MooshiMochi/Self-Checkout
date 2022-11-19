import { Button, TextInput } from '@mantine/core';
import { useForm } from '@mantine/form';
import { React } from 'react';
import { Helmet } from 'react-helmet';

export default function Login() {
  const form = useForm({
    initialValues: {
      email: '',
      password: '',
    },
    validate: {
      email: (value) => (/^\S+@\S+$/.test(value) ? null : 'Invalid email'),
      password: (value) =>
        value.length > 0 ? null : 'Password must be at least 1 character long',
    },
    validateInputOnChange: true,
  });

  const login = async (e) => {
    console.log('login');
    // e.preventDefault();
    // const res = await fetch('/api/login', {
    //   method: 'POST',
    //   headers: {
    //     'Content-Type': 'application/json',
    //   },
    //   body: JSON.stringify({
    //     email: form.values.email,
    //     password: form.values.password,
    //   }),
    // });
    // const data = await res.json();
    // console.log(data);
    // if (data.error) {
    //   console.log(data.error);
    // }
    // if (data.token) {
    //   console.log(data.token);
    // }
  };
  return (
    <>
      <Helmet>
        <meta charset='UTF-8' />
        <meta http-equiv='X-UA-Compatible' content='IE=edge' />
        <meta name='viewport' content='width=device-width, initial-scale=1.0' />
        <title>Age Verification | Home</title>
      </Helmet>
      <div>
        <main className='flex flex-col justify-center items-center h-screen m-auto fixed top-1/2 left-1/2 -translate-y-1/2 -translate-x-1/2 text-center'>
          <h1 className='text-1x1'>Customer Login</h1>

          <form
            onSubmit={form.onSubmit((values) => {
              console.log(values);
            })}
            className='flex flex-col'
            action='/TEST_TARGET'
          >
            <TextInput
              type='username'
              name='username'
              id='username'
              placeholder='Username'
              className='lg:w-1/8 mt-4'
              {...form.getInputProps('username')}
            />
            <TextInput
              type='password'
              name='password'
              id='password'
              placeholder='Password'
              className='lg:w-1/8 mt-4'
              {...form.getInputProps('password')}
            />
            <Button
              type='submit'
              variant='outline'
              color='green'
              className='lg:w-1/2 lg:h-1/12 mt-2 rounded-lg border-4 border-teal-300 shadow-inner shadow-gray-600 text-inherit'
              onClick={() => {
                login();
              }}
            >
              Sign in
            </Button>
          </form>
        </main>
      </div>
    </>
  );
}
