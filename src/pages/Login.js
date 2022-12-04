import { Button, PasswordInput, TextInput } from '@mantine/core';
import { useForm } from '@mantine/form';
import { useState } from 'react';
import { useNavigate } from 'react-router-dom';
import { emailRegex } from '../utils';

export default function Signup() {
  // eslint-disable-next-line no-unused-vars
  const navigate = useNavigate();

  const form = useForm({
    initialValues: {
      username: '',
      password: '',
    },
    validate: {
      username: (value) =>
        emailRegex.test(value) ? null : 'Invalid email address',
      password: (value) =>
        value.length > 6 ? null : 'Password must be at least 6 characters long',
    },
    validateInputOnChange: true,
  });

  function btnSubmit() {
    fetch('http://127.0.0.1:8000/login', {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json',
      },
      body: JSON.stringify({
        username: form.getInputProps('username').value,
        password: form.getInputProps('password').value,
      }),
    })
      .then((res) => res.json())
      .then((data) => {
        console.log(data);
        if (data.success) {
          navigate('/home');
        } else {
          setFailMessage(true);
        }
      });
  }

  const [failMessage, setFailMessage] = useState(false);

  return (
    <>
      <div className='w-11/12 translate-y-1/4 md:w-1/2 lg:w-2/5 mx-auto h-64 md:h-96'>
        <h1 className='text-2xl text-center flex flex-col justify-center'>
          Customer Login
        </h1>
        <form
          className='m-auto'
          onSubmit={() => {
            btnSubmit();
          }}
        >
          <TextInput
            label='Username'
            placeholder='Enter your username'
            required
            {...form.getInputProps('username')}
          />
          <PasswordInput
            label='Password'
            placeholder='Enter your password'
            required
            {...form.getInputProps('password')}
          />
          <Button
            type='submit'
            variant='outline'
            color='green'
            className='w-full'
            onClick={() => {
              btnSubmit();
            }}
          >
            Log in
          </Button>
        </form>
        {failMessage ? (
          <div className='text-center text-xs translate-y-1/2 text-2x1'>
            <p className='font-thin'>
              Invalid username or password. Please try again
            </p>
            <a href='#/forgot-password' className='font-black'>
              Reset password here
            </a>
          </div>
        ) : null}
      </div>
    </>
  );
}
