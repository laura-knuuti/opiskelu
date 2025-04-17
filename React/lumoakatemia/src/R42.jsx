import {useState, useEffect} from "react";

export default function MemeList() {
    const [memes, setMemes] = useState([]);

    useEffect(() => {
        fetch ('https://api.imgflip.com/get_memes')
        .then(response => response.json())
        .then(data => {
            setMemes(data.data.memes);
        });
    }, []);
    return (
        <div>
            <h3>Memejä:</h3>
            <ul>
            {memes.map(meme => (
            <li key={meme.id}>
            <img src = {meme.url} alt = {meme.name}
            style={{ width: "300px", height: "auto" }} 
            />
            </li>
        ))}
        </ul>
        </div>
);
}