export default function Kirja ({kirjailija, tyylilaji, otsikko}) {
    return (
        <div>
            <p>
            <strong>Kirjailija:</strong>   {kirjailija}<br/>
            <strong>Tyylilaji:</strong>    {tyylilaji}
            </p>
            <h3>{otsikko} </h3>
            
        </div>
    )
}