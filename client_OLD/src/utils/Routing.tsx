import {
  BrowserRouter,
  Routes,
  Route
} from "react-router-dom";

import Main from "../containers/layouts/Main";
import Home from "../containers/views/Home";
import About from "../containers/views/About";

import Blank from "../containers/layouts/Blank";
import SignIn from "../containers/views/Auth/SignIn";

const Routing = () => (
  <BrowserRouter>
    <Routes>
      <Route path="/" element={<Main />}>
        <Route index element={<Home />} />
        <Route path="/about" element={<About />} />
      </Route>

      <Route path="/auth" element={<Blank />}>
        <Route index element={<SignIn />} />
      </Route>
    </Routes>
  </BrowserRouter>
);

export default Routing;