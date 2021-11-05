import { Route, BrowserRouter } from "react-router-dom";

//Pages
import Home from "./Pages/Home/index";
import Paciente from "./Pages/Paciente/index";
import Profissional from "./Pages/Profissional/index";

function Routes() {
  return (
    <BrowserRouter>
      <Route component={Home} path="/" exact />
      <Route component={Paciente} path="/cadastro-paciente" />
      <Route component={Profissional} path="/cadastro-profissional" />
    </BrowserRouter>
  );
}

export default Routes;
