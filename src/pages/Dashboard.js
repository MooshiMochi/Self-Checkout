import React from 'react';

const Dashboard = () => {
  return (
    <div className='grid grid-rows-3'>
      <div className='flex justify-between'>
        <div>Sample QR Code</div>
        <div className='flex flex-col'>
          <div>Personal Details</div>
          <div>Stuff</div>
        </div>
        <div>
          <button>Log Out</button>
        </div>
      </div>
      <div className='flex flex-col'>
        <div>Home Address</div>
        <div>Home Address Info</div>
      </div>
      <div>Image</div>
      <div className='grid grid-rows-3'>
        <button>Select an Image</button>
        <button>Upload an Image</button>
        {/* <input>Select an Image</input>
        <input>Upload an image</input> */}
      </div>
      <div className='text-center max-w-md'>
        If your personal details or home address are not filled then it is
        likely that your ID is not supported or the picture is blurry. Please
        re-upload a clearer picture or your ID.
      </div>
    </div>
  );
};

export default Dashboard;
