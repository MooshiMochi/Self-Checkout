import { Button, PasswordInput, TextInput } from '@mantine/core';
import { useForm } from '@mantine/form';
import { useNavigate } from 'react-router-dom';
import { emailRegex } from '../utils';

export default function Signup() {
  const navigate = useNavigate();

  const form = useForm({
    initialValues: {
      email: '',
      password: '',
      passwordConfirm: '',
    },
    validate: {
      email: (value) => (emailRegex.test(value) ? null : 'Invalid email'),
      password: (value) =>
        value.length >= 6
          ? null
          : 'Password must be at least 6 characters long',
      passwordConfirm: (value, values) =>
        values.password !== value ? 'Passwords do not match' : null,
    },
    validateInputOnChange: true,
  });

  function requestSignUP() {
    let email = form.getInputProps('email').value;
    let pass = form.getInputProps('password').value;
    console.log(`Email: ${email} Password: ${pass}`);
    fetch('http://localhost:8000/register', {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json',
      },
      body: JSON.stringify({
        email: email,
        password: pass,
      }),
    })
      .then((res) => res.json())
      .then((data) => {
        if (data.success) {
          navigate('/login');
        } else {
          form.setFieldError('email', 'This email is already in use');
        }
      });
  }

  return (
    <>
      {/*used md: to create breakpoint for at a width of tablet size Same with the others.  */}
      <div className='md:grid grid-cols-2 h-64 lg:h-72 2xl:h-96 md:mr-6'>
        <h1 className='text-2xl text-center flex flex-col justify-center'>
          Sign Up
        </h1>
        <form
          className='w-11/12 lg:w-2/3 m-auto'
          onSubmit={(values) => {
            // console.log(values);
            form.onSubmit(values);
            requestSignUP();
          }}
        >
          {/*Changed the width for different media devices to make form look smaller */}
          <TextInput
            label='Email'
            placeholder='Enter your email'
            required
            {...form.getInputProps('email')}
          />
          <PasswordInput
            label='Password'
            placeholder='Enter your password'
            required
            {...form.getInputProps('password')}
          />
          <PasswordInput
            label='Confirm Password'
            placeholder='Confirm your password'
            required
            {...form.getInputProps('passwordConfirm')}
          />
          <Button
            type='submit'
            variant='outline'
            color='green'
            className='w-full'
          >
            Sign up
          </Button>
        </form>
      </div>
    </>
  );
}
