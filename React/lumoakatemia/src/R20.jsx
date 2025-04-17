function Tuotelista()
{
    const tuotteet = ["Tuote 1: Hinta 10€", "Tuote 2: Hinta 12€", "Tuote 3: Hinta 15€", "Tuote 4: Hinta 18€ ", "Tuote 5: Hinta 20€"];
        const lista = tuotteet.map(tuotteet =>
         <li key = {tuotteet}>{tuotteet}</li>);

         return (
            <ul>
                {lista}
            </ul>
         );
}

export default Tuotelista;