import { Button, TextInput } from '@mantine/core';
import { useForm } from '@mantine/form';
import { React, useState } from 'react';
import { Helmet } from 'react-helmet';
import { useNavigate } from 'react-router-dom';

export default function ForgotPass() {
  const navigate = useNavigate();
  // let form = useForm({
  // const [enterCode, showEnterCode] = useState(false);

  const [passwordReset, setPasswordReset] = useState(false);
  const [clicked, setClicked] = useState(0);

  const emailForm = useForm({
    initialValues: {
      email: '',
    },
    validate: {
      email: (value) => (/^\S+@\S+$/.test(value) ? null : 'Invalid email'),
    },
    validateInputOnChange: true,
  });

  const codeForm = useForm({
    initialValues: {
      code: '',
    },
    validate: {
      code: (value) => (/^\d{6}$/.test(value) ? null : 'Invalid code'),
    },
    validateInputOnChange: true,
  });

  const emailExists = (email) => {
    fetch(`http://localhost:8000/api/users?email=${email}`, {
      method: 'GET',
      headers: {
        'Content-Type': 'application/json',
      },
    })
      .then((res) => res.json())
      .then((data) => {
        if (data.length === 0) {
          emailForm.setFieldError('email', 'This email does not exist');
        } else {
          // sendEmail(email);
          // form.clearFieldError('email');
        }
      });
  };

  let page = !passwordReset ? (
    <div>
      <h1 className='text-6xl flex flex-col justify-center'>Forgot Password</h1>
      <h2 className='text-base align-text-top flex flex-col justify-center'>
        {clicked === 1 ? (
          <div>
            We've found the email ... linked to your account<br></br>
            Please enter the verification code sent
          </div>
        ) : (
          'Please enter your email address'
        )}
      </h2>

      <form
        // onSubmit={form.onSubmit((values) => {
        //   console.log(values);
        //   form.setFieldValue('email', '');
        // })}
        className='flex flex-col'
        action='/TEST_TARGET'
      >
        {/* There is a very annoying bug here... for some reason having this makes the page not render and idk why.... */}
        {clicked === 0 ? (
          <TextInput
            type='email'
            name='email'
            id='email'
            placeholder='your@email.com'
            className='lg:w-1/3 mt-4'
            {...emailForm.getInputProps('email')}
          ></TextInput>
        ) : (
          <TextInput
            type='number'
            name='code'
            id='code'
            placeholder='Verification Code'
            className='lg:w-1/3 mt-4'
            {...codeForm.getInputProps('code')}
          ></TextInput>
        )}
        <div className='lg:w-1/6 lg:h-6'>
          <Button
            type='submit'
            variant='outline'
            color='green'
            className='lg:w-1/2 lg:h-1/12 mt-2 rounded-lg border-4 border-teal-300 shadow-inner shadow-gray-600 text-inherit'
            onClick={() => {
              if (clicked === 0) {
                let email = emailForm.getInputProps('email').value;
                emailExists(email);
              }
              setClicked(clicked + 1);
              clicked === 2 ? setPasswordReset(true) : setPasswordReset(false);
              console.log('Cleared input field');
            }}
          >
            Next
          </Button>
        </div>
      </form>
    </div>
  ) : (
    <div className='text-center w-full mx-auto'>
      <h1 className='text-6xl'>Forgot Password</h1>
      <div>Your password has been reset</div>
      <div className='lg:w-1/6 lg:h-6'>
        <Button
          type='submit'
          variant='outline'
          color='green'
          className=' lg:w-1/2 lg:h-1/12 mt-2 rounded-lg border-4 border-teal-300 shadow-inner shadow-gray-600 text-inherit'
          onClick={() => {
            navigate('/login');
          }}
        >
          Next
        </Button>
      </div>
    </div>
  );

  return (
    <>
      <Helmet>
        <meta charset='UTF-8' />
        <meta http-equiv='X-UA-Compatible' content='IE=edge' />
        <meta name='viewport' content='width=device-width, initial-scale=1.0' />
        <title>Age Verification | Forgot Password</title>
      </Helmet>

      <main className='flex flex-col translate-y-1/4 m-4'>{page}</main>
    </>
  );
}
