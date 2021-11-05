import AsideImg from "../../Assets/images/Aside.svg";
import "./styles.scss";
export default function Aside() {
  return (
    <aside>
        <img src={AsideImg} alt="Imagem representando médicos" /> 
        <strong>Trazendo saúde para você</strong>
        <p>Conectamos você ao profissional de sáude certo</p>       
    </aside>
  );
}