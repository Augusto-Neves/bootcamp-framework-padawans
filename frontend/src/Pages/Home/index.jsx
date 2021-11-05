import { Link } from "react-router-dom";

import "./styles.scss";
import Logo from "../../Assets/images/Logo.png";
import Google from "../../Assets/images/google.png";

export default function Home() {
  return (
    <>
      <main>
        <Link to="/">
          <img src={Logo} alt="Mais Saúde Logo" />
        </Link>

        <div className="container">
          <header>
            <h3>Seja Bem-vindo</h3>
            <h2>Entre com sua conta</h2>
          </header>

          <form>
            <label htmlFor="email">Email</label>
            <input name="email" type="text" id="email" />

            <label htmlFor="password">Senha</label>
            <input name="password" id="password" type="password" />
            <span>Esqueci minha senha</span>
            <button type="submit" className="button">
              Login
            </button>
            <button className="google-login">
              <img src={Google} alt="Google-Icon" /> ou com sua conta google
            </button>
          </form>
        </div>

        <span>
          Ainda não tem conta? <Link to="/">Cadastre-se</Link>
        </span>
      </main>
    </>
  );
}
