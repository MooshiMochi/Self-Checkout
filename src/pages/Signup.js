import { PasswordInput, TextInput } from "@mantine/core";
import { useForm } from "@mantine/form";

export default function Signup() {
  const form = useForm({
    initialValues: {
      email: "",
      password: "",
      password_confirm: "",
    },
    validate: {
      email: (value) => (/^\S+@\S+$/.test(value) ? null : "Invalid email"),
      password: (value) =>
        value.length > 6 ? null : "Password must be at least 6 characters long",
      password_confirm: (value) =>
        value === form.values.password ? null : "Passwords do not match",
    },
  });

  return (
    <>
      <form
        className='flex justify-around'
        onSubmit={form.onSubmit(console.log)}
      >
        <TextInput
          label='Email'
          className=''
          {...form.getInputProps("email")}
        />
        <PasswordInput label='Password' {...form.getInputProps("password")} />
        <PasswordInput
          label='Confirm Password'
          {...form.getInputProps("password_confirm")}
        />
        <div>
          <button
            type='submit'
            className='text-xs p-0 h-fit translate-y-[46px]'
            id='submit-button'
          >
            Register
          </button>
        </div>
      </form>
    </>
  );

  // const signup = async (e) => {};

  // return (
  //   <div>
  //     <h1>Signup</h1>
  //   </div>
  // );
}
