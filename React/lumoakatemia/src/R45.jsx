import {useState, useEffect} from "react";

export default function Hauvat() {
    const [dogs, setDogs] = useState([]);

    useEffect(() => {
        fetch ('https://dog.ceo/api/breeds/image/random/5')
        .then(response => response.json())
        .then(data => {
            setDogs(data.message);
        });
    }, []);
    return (
        <div>
            <h3>Paljon hauvoja:</h3>
            <ul>
            {dogs.map((koiraUrl, index) => (
            <li key={index} style={{ listStyle: "none" }}>
            <img src = {koiraUrl} alt = "hauveli"
            style={{ width: "300px", height: "auto" }} 
            />
            </li>
        ))}
        </ul>
        </div>
);
}