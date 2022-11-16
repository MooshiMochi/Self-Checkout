import { useForm } from '@mantine/form';

export default function Login() {
  const form = useForm({
    initialValues: {
      email: '',
      password: '',
    },
  });

  const login = async (e) => {};
  return (
    <div>
      <h1>Login</h1>
    </div>
  );
}
