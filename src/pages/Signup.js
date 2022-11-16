import { useForm } from '@mantine/form';

export default function Signup() {
  const form = useForm({
    initialValues: {
      email: '',
      password: '',
    },
  });

  const signup = async (e) => {};

  return (
    <div>
      <h1>Signup</h1>
    </div>
  );
}
