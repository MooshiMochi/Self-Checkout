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

  const [failMessage, showFailMessage] = useState(false);

  return (
    <>
      {/*used md: to create breakpoint for at a width of tablet size Same with the others.  */}
      {/* md:grid h-64 lg:h-72 2xl:h-96 md:mr-6 mx-auto */}
      <div className='w-11/12 translate-y-1/4 md:w-1/2 lg:w-2/5 mx-auto h-64 md:h-96'>
        <h1 className='text-2xl text-center flex flex-col justify-center'>
          Customer Login
        </h1>
        <form
          className='m-auto'
          onSubmit={(values) => {
            console.log(values);
            form.onSubmit(values);
            alert('Logged in successfully!');
            showFailMessage(true);
            // navigate('/home');
          }}
        >
          {/*Changed the width for different media devices to make form look smaller */}
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
          >
            Log in
          </Button>
        </form>

        {showFailMessage ? (
          <div className='text-center text-xs translate-y-1/2 text-2x1'>
            <p className='font-thin'>
              {!failMessage ? 'Invalid username or password' : failMessage}
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
