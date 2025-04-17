export default function Kommentti(props) {
    return (
        <div>
            <h3>{props.poliitikko}:</h3> <h4 style ={{fontStyle: 'italic'}}>{props.sitaatti}</h4>
        </div>
    );
}