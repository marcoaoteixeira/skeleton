import { Outlet } from "react-router-dom";

const Blank = () => {
  return (
    <div>
      <h1>Blank</h1>
      <Outlet />
    </div>
  );
};

export default Blank;