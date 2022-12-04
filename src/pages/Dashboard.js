import React from 'react';
import { useNavigate } from 'react-router-dom';

const Dashboard = () => {
  const navigate = useNavigate();
  const base_box_style =
    'rounded-lg shadow-lg border-4 border-teal-300 bg-grey-300';
  // w-1/3 flex flex-col justify-center items-center
  return (
    <>
      <div
        className='grid grid-rows-2 w-full text-center text-base h-1/2'
        id='TABLE'
      >
        <div
          className='flex flex-row justify-around items-center rounded-md border-red-500 border-4 relative'
          id='ROW'
        >
          <div className={base_box_style + ' w-1/5'}>Sample QR Code</div>
          <div className='w-2/5'>
            <div className=''>Personal Details</div>
            <div className={base_box_style + ' content-editable'}>
              Name: ...<br></br>
              Date of Birth: ...<br></br>
              Customer ID: ...
            </div>
          </div>
          <div className='w-1/5'>
            <button onClick={() => navigate('/')}>Log Out</button>
          </div>
        </div>
        <div
          className='flex flex-row justify-around items-center rounded-md border-green-500 border-4'
          id='ROW'
        >
          <div>
            <div>Home Address</div>
            <div className={base_box_style}>
              House Number: ...<br></br>
              Street Name: ...<br></br>
              City: ...<br></br>
              Post Code: ...
            </div>
          </div>
          <div className={base_box_style}>Sample Image</div>
          <div>
            <div>
              <button>Select an image</button>
            </div>
            <div>
              <button>Upload an image</button>
            </div>
          </div>
        </div>
      </div>
      <div className='rounded-md border-blue-500 border-4 flex justify-center items-center align-middle text-xs text-center'>
        If your personal details or home address are not filled then it is
        likely that your ID is not supported or the picture is blurry. Please
        re-upload a clearer picture of your ID.
      </div>
    </>
  );
};

export default Dashboard;

// <div className='grid grid-rows-3 w-full text-center'>
//       <div className='flex justify-between bg-'>
//         <div className={base_box_style}>Sample QR Code</div>
//         <div className='flex flex-col w-1/3'>
//           <div className='text-left'>Personal Details</div>
//           <div className={base_box_style + ' text-left'}>
//             Name: ...<br></br>
//             Date of Birth: ...<br></br>
//             Customer ID: ...
//           </div>
//         </div>
//         <div>
//           <button
//             className={base_box_style}
//             onClick={() => {
//               navigate('/');
//             }}
//           >
//             Log Out
//           </button>
//         </div>
//       </div>
//       <div className='flex justify-between border-8 border-red-800 w-full'>
//         <div className='flex flex-col'>
//           <div className='text-left'>Home Address</div>
//           <div className={base_box_style + ' text-left'}>
//             House Number: ...<br></br>
//             Street Name: ...<br></br>
//             City: ...<br></br>
//             Post Code: ...
//           </div>
//         </div>
//         <div className={base_box_style}>Image</div>
//         <div className='grid grid-rows-3 text-center'>
//           <button className='rounded-lg shadow-lg'>Select an Image</button>
//           <button className='rounded-lg shadow-lg'>Upload an Image</button>
//           {/* <input>Select an Image</input>
//         <input>Upload an image</input> */}
//         </div>
//       </div>

//       <div className='text-center max-w-md w-full translate-x-1/2 text-sm translate-y-1/4 p-0 font-bold'>
//         If your personal details or home address are not filled then it is
//         likely that your ID is not supported or the picture is blurry. Please
//         re-upload a clearer picture or your ID.
//       </div>
//     </div>
