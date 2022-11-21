import React from 'react';
import { useNavigate } from 'react-router-dom';

const Dashboard = () => {
  const navigate = useNavigate();
  const base_box_style =
    'rounded-lg shadow-lg border-4 border-teal-200 w-1/3 flex flex-col justify-center items-center bg-grey-200';
  return (
    <div className='grid grid-rows-3 w-full p-5 text-center'>
      <div className='flex justify-between'>
        <div className={base_box_style}>Sample QR Code</div>
        <div className='flex flex-col'>
          <div>Personal Details</div>
          <div className={base_box_style}>Stuff</div>
        </div>
        <div>
          <button
            className='rounded-lg shadow-lg'
            onClick={() => {
              navigate('/');
            }}
          >
            Log Out
          </button>
        </div>
      </div>
      <div className='flex justify-between border-8 border-red-800'>
        <div className='flex flex-col'>
          <div>Home Address</div>
          <div className={base_box_style}>Home Address Info</div>
        </div>
        <div className={base_box_style}>Image</div>
        <div className='grid grid-rows-3 text-center'>
          <button className='rounded-lg shadow-lg'>Select an Image</button>
          <button className='rounded-lg shadow-lg'>Upload an Image</button>
          {/* <input>Select an Image</input>
        <input>Upload an image</input> */}
        </div>
      </div>

      <div className='text-center max-w-md w-full translate-x-1/2 text-sm translate-y-1/4 p-0 font-bold'>
        If your personal details or home address are not filled then it is
        likely that your ID is not supported or the picture is blurry. Please
        re-upload a clearer picture or your ID.
      </div>
    </div>
  );
};

export default Dashboard;
