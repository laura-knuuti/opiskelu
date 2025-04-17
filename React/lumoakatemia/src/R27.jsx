export default function Tehtava (props){
    return (
    <div>
        <h3>Tehtävän kuvaus:</h3>
        <strong>{props.kuvaus}</strong>
        <h3>Tila:</h3>
        <strong>{props.status ? 'Valmis' : 'Kesken'}</strong>
    </div>
     );
}