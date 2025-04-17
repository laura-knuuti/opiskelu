import {useState, useEffect} from "react";

export default function Uutiset() {
    const [news, setNews] = useState([]);

    useEffect(() => {
        fetch ('https://newsapi.org/v2/top-headlines?country=us&apiKey=f7d7f4d4b8a7435da57241e4389de84f')
        .then(response => response.json())
        .then(data => {
            setNews(data.articles);
        });
    }, []);
    return (
        <div>     
            {news.map((article, index) => (
            <div key={index}>
            <h3>{article.title}</h3>
            <p>{article.description}</p>
          <p><a href={article.url} target="_blank" rel="noopener noreferrer">Lue lisää</a></p>
        </div>
            ))}
            </div>
);
}