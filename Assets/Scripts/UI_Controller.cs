using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.InputSystem;
using TMPro;

public class UI_Controller : MonoBehaviour
{
    public GameObject _MainMenu, _LocationsMenu, _Credits, _LocationGuidance, _TripPlanner;
    public VideoClip[] _Location_Videos = new VideoClip[9];
    public VideoPlayer _Location_PLayer;
    public static int locationNum;
    public TMP_Text Information;

    public GameObject RoomSelect;         
    public GameObject ShoppingSelect;       
    public GameObject TransportSelect;      
    public GameObject FoodSelect;

    public GameObject TripPlannerPage;



    public static UI_Controller _instance;

    public void OnEnable()
    {
        _instance = this;
    }

    //public InputActionProperty _AButtonPressed;
    //public InputActionProperty _BButtonPressed;

    public struct _ExtraInfo
    {
        public string food;
        public string locations;
        public string transportation;
        public string shopping;
        public string importantPlaces;
        public string rooms;
    };


    _ExtraInfo[] objs1 = { new _ExtraInfo(), new _ExtraInfo(), new _ExtraInfo(), new _ExtraInfo(), new _ExtraInfo(), new _ExtraInfo(), new _ExtraInfo(), new _ExtraInfo(), new _ExtraInfo() };
    public void Start() {
        

        objs1[0].food = "Foods to Try:\n- Bedai & Jalebi: A popular breakfast dish with spicy lentil-filled bread and sweet jalebi.\n- Petha: A translucent sweet made from ash gourd, available in various flavors.\n- Mughlai Dishes: Rich curries, kebabs, and biryanis that reflect Mughal heritage.\n- Chaat: Street food favorites like aloo tikki, golgappa, and papdi chaat.\n\nPopular Restaurants:\n- Peshawri (ITC Mughal): Known for authentic Mughlai cuisine.\n- Pinch of Spice: Indian, Chinese, and Continental dishes in a fine dining setting.\n- The Salt Cafe: Rooftop dining with fusion items like Butter Chicken Pasta.\n- Daawat-e-Nawab (Taj Hotel): Nawabi dishes with live classical music.\n- Sky Deck (Tajview Hotel): Offers Continental and Indian food with Taj Mahal views.";
        objs1[0].locations = "General Information About Agra and the Taj Mahal\n\nLocation: Agra is situated in Uttar Pradesh, approximately 176 km from New Delhi.\n\nTaj Mahal: Commissioned in 1632 by Mughal Emperor Shah Jahan in memory of his wife Mumtaz Mahal, the Taj Mahal is an ivory - white marble mausoleum on the south bank of the Yamuna River.\n\nVisiting Hours: The monument is open from sunrise to sunset, closed on Fridays for general viewing.\n\nBest Time to Visit: October to March offers pleasant weather, ideal for sightseeing.";
        objs1[0].transportation = "Getting Around Agra:\n- Auto-Rickshaws & Cycle-Rickshaws: Best for short local trips and sightseeing.\n- Taxis & Private Rentals: Ideal for comfort and longer distances.\n- Agra Metro: Currently operational from Taj East Gate to Mankameshwar.\n- Eco-Friendly: Battery buses and horse-drawn tongas available near the Taj.\n\nTip: The Taj Mahal is in a no-vehicle zone. You’ll need to walk or take an electric shuttle from the parking areas.";
        objs1[0].shopping = "Where to Shop in Agra:\n- Sadar Bazaar: Souvenirs, leather goods, handicrafts, and snacks.\n- Kinari Bazaar: Jewelry, textiles, and embroidered garments.\n- Subhash Bazaar: Specializes in silk and sarees.\n- Shilpgram: Government-run complex near the Taj with crafts and cultural performances.\n\nMust-Buy Items:\n- Marble replicas of the Taj Mahal\n- Petha sweets\n- Leather shoes and bags";
        objs1[0].importantPlaces = "Nearby Attractions:\n- Agra Fort: A red sandstone fortress, UNESCO World Heritage Site.\n- Mehtab Bagh: Garden with a perfect sunset view of the Taj from across the Yamuna.\n- Itimad-ud-Daulah’s Tomb: Known as the Baby Taj, rich with carvings and inlay work.\n- Fatehpur Sikri: A 16th-century city built by Emperor Akbar, about 40 km from Agra.\n- Mughal Heritage Walk: A guided rural tour through Kachhpura village and lesser-known monuments.";
        objs1[0].rooms = "Accommodation Options:\nLuxury:\n- The Oberoi Amarvilas: Premier views of the Taj Mahal, luxurious amenities.\n- ITC Mughal: Lavish decor with Mughal architecture and spa facilities.\n\nMid-Range:\n- Trident Agra: Comfortable, family-friendly with great service.\n- Tajview Agra: Modern hotel with view-facing rooms.\n\nBudget:\n- Joey’s Hostel: Backpacker-friendly with basic amenities.\n- Hotel Sidhartha: Very close to the Taj, good for short stays.";

        objs1[1].food = "Foods to Try:\n- Croissants and Baguettes: Classic French pastries available at local bakeries.\n- Escargots: Snails prepared with garlic and parsley butter.\n- Duck Confit: Slow-cooked duck leg, a traditional French dish.\n- Crêpes: Thin pancakes with sweet or savory fillings.\n\nPopular Restaurants:\n- Le Jules Verne: Michelin-starred restaurant located on the Eiffel Tower's second floor, offering gourmet French cuisine.\n- Madame Brasserie: Casual dining on the first floor of the Eiffel Tower with panoramic views.\n- Aux Artistes: Local bistro known for its escargots and traditional dishes.\n- Le P’tit Troquet: Cozy restaurant offering classic French meals.\n- Auberge Bressane: Traditional eatery serving regional specialties.";
        objs1[1].transportation = "Getting Around Paris:\n- Metro: The Eiffel Tower is accessible via Line 6 (Bir-Hakeim station) and Line 9 (Trocadéro station).\n- RER: Line C stops at Champ de Mars–Tour Eiffel station.\n- Buses: Several lines, including 42, 69, 82, and 87, have stops near the Eiffel Tower.\n- Batobus: A hop-on, hop-off boat service along the Seine River with a stop at the Eiffel Tower.\n- Vélib': Paris's bike-sharing program with stations near the Eiffel Tower.";
        objs1[1].shopping = "Shopping Near the Eiffel Tower:\n- Rue Cler: A charming market street offering fresh produce, cheeses, wines, and more.\n- Beaugrenelle Shopping Center: A modern mall with a variety of fashion and lifestyle stores.\n- Champs-Élysées: Famous avenue featuring luxury boutiques and flagship stores.\n- Local Souvenir Shops: Numerous stores around the Eiffel Tower selling memorabilia and gifts.";
        objs1[1].importantPlaces = "Nearby Attractions:\n- Trocadéro Gardens: Offers one of the best views of the Eiffel Tower.\n- Musée du Quai Branly: Museum showcasing indigenous art and cultures.\n- Champ de Mars: Large public greenspace ideal for picnics and relaxation.\n- Seine River Cruises: Boat tours providing unique perspectives of Paris landmarks.\n- Les Invalides: Complex containing museums and Napoleon's tomb.";
        objs1[1].rooms = "Accommodation Options:\nLuxury:\n- Shangri-La Hotel: Former royal residence with Eiffel Tower views and Michelin-starred dining.\n- Pullman Paris Tour Eiffel: Modern hotel located near the Eiffel Tower with contemporary amenities.\n\nMid-Range:\n- Hôtel La Bourdonnais: Boutique hotel offering elegant rooms close to the Eiffel Tower.\n- Hôtel Le Cercle Tour Eiffel: Stylish accommodations within walking distance to the tower.\n\nBudget:\n- Hôtel Eiffel Rive Gauche: Affordable hotel offering basic amenities near the Eiffel Tower.\n- Hôtel de la Tour Eiffel: Budget-friendly option with a prime location.";
        objs1[1].locations = "General Information About Paris and the Eiffel Tower\n\nParis: Paris is the capital and largest city of France, located in the north-central part of the country along the Seine River. Known as the 'City of Light,' it has been a major center for art, fashion, gastronomy, and culture since the 17th century. The city covers an area of 105.4 square kilometers and has a population of over 2 million residents. Paris is renowned for its historical landmarks, museums, and vibrant neighborhoods.\n\nEiffel Tower: The Eiffel Tower (La Tour Eiffel) is a wrought-iron lattice tower on the Champ de Mars in Paris. Designed by engineer Gustave Eiffel, it was constructed between 1887 and 1889 as the entrance arch for the 1889 World's Fair, held to commemorate the centennial of the French Revolution. Standing at 330 meters (1,083 feet) tall, it was the tallest man-made structure in the world until 1930. Initially criticized by some of France's leading artists and intellectuals for its design, it has become a global cultural icon of France and one of the most recognizable structures in the world.\n\nVisiting Hours: The Eiffel Tower is open every day of the year. Opening hours vary by season, typically from 9:30 AM to 11:45 PM. Visitors can access the tower via elevators or stairs, with tickets available for different levels.\n\nBest Time to Visit: The best times to visit Paris are from April to June and October to early November when the weather is mild and enjoyable, and tourist crowds are smaller compared to the peak summer months.";


        objs1[2].locations = "General Information About the Great Wall of China\n\nThe Great Wall of China is an extensive fortification system built across northern China over several centuries to protect against invasions. Stretching over 21,000 kilometers, it is the longest man-made structure in the world. The wall traverses diverse terrains, including mountains, deserts, and plains, and comprises various sections built during different dynasties.\n\nNotable Sections:\n- Badaling: The most visited and well-preserved section, easily accessible from Beijing.\n- Mutianyu: Known for its beautiful scenery and fewer crowds, featuring a toboggan ride and cable car.\n- Jinshanling: Offers a mix of restored and wild wall segments, ideal for hiking enthusiasts.\n\nVisiting Hours:\n- Badaling: 6:30 AM – 4:30 PM\n- Mutianyu: 8:00 AM – 5:00 PM\n(Note: Hours may vary by season; it's advisable to check official sources before visiting.)\n\nBest Time to Visit:\n- Spring (April to June): Mild temperatures and blooming flowers.\n- Autumn (September to November): Comfortable weather with colorful foliage.";

        objs1[2].food = "Foods to Try:\n- Peking Duck: A famous Beijing dish featuring crispy roasted duck.\n- Zhajiangmian: Noodles with soybean paste, a local favorite.\n- Dumplings: Various fillings, steamed or fried, commonly found in the region.\n\nPopular Restaurants Near the Great Wall:\n- The Schoolhouse at Mutianyu: Offers Western-style dishes with local ingredients.\n- Xin Shuang Quan Restaurant: Serves traditional Chinese meals near the Mutianyu section.\n- Commune Kitchen: Located at Commune by the Great Wall, offering a fusion menu.";

        objs1[2].transportation = "Getting to the Great Wall:\n- Badaling:\n  - Train: Take the S2 line from Beijing North Railway Station to Badaling Station.\n  - Bus: Bus 877 from Deshengmen Bus Station directly to Badaling.\n- Mutianyu:\n  - Bus: Take bus 916 Express from Dongzhimen to Huairou, then transfer to a local bus or taxi.\n  - Tour Buses: Various tour operators offer direct buses to Mutianyu.\n\nOn-Site Transportation:\n- Cable Cars: Available at both Badaling and Mutianyu for easier access to the wall.\n- Toboggan Ride: A fun descent option at the Mutianyu section.";

        objs1[2].shopping = "Shopping Near the Great Wall:\n- Souvenir Shops: Located at the entrances of major sections like Badaling and Mutianyu, selling replicas, postcards, and local crafts.\n- Local Markets: In nearby villages, offering handmade items and traditional snacks.\n- Beijing City: For a broader shopping experience, Beijing offers various markets and malls with a wide range of products.";

        objs1[2].importantPlaces = "Nearby Attractions:\n- Great Wall Museum: Located near the Badaling section, showcasing the history and construction of the wall.\n- Ming Tombs: A collection of mausoleums built by the emperors of the Ming dynasty.\n- Summer Palace: A vast ensemble of lakes, gardens, and palaces in Beijing.\n- Forbidden City: The former imperial palace in Beijing, now a museum.";

        objs1[2].rooms = "Accommodation Options:\nLuxury:\n- Commune by the Great Wall: A boutique hotel with unique architecture near the Shuiguan section.\n- Sunrise Kempinski Hotel: A five-star hotel offering lake views, located in Yanqi Lake area.\n\nMid-Range:\n- Brickyard Retreat at Mutianyu: Offers comfortable rooms with views of the Great Wall.\n- Huairou Hotel: A standard hotel located in the Huairou district, convenient for Mutianyu visitors.\n\nBudget:\n- Local Guesthouses: Various family-run guesthouses in nearby villages offer affordable stays.\n- Hostels in Beijing: For those preferring to stay in the city and make day trips to the wall.";


        objs1[3].locations = "General Information About Machu Picchu\n\nMachu Picchu is a 15th-century Inca citadel located in the Eastern Cordillera of southern Peru on a mountain ridge at 2,430 meters above sea level. Often referred to as the 'Lost City of the Incas,' it is one of the most iconic symbols of the Inca Empire. The site is situated above the Sacred Valley, 80 km northwest of Cusco, and is surrounded by lush tropical forests and steep mountains.\n\nVisiting Hours: Machu Picchu is open daily from 6:00 AM to 5:30 PM. Entry is regulated through designated time slots, and visitors are required to follow specific circuits within the site.\n\nBest Time to Visit: The dry season, from April to October, offers the most stable weather conditions. For fewer crowds and pleasant weather, consider visiting in April-May or September-November.";

        objs1[3].food = "Foods to Try:\n- Lomo Saltado: Stir-fried beef with onions, tomatoes, and fries.\n- Alpaca Steak: Lean and tender meat, often grilled.\n- Quinoa Soup: Traditional Andean soup made with quinoa and vegetables.\n- Pisco Sour: Peru's national cocktail made with pisco, lime juice, and egg white.\n\nPopular Restaurants:\n- Indio Feliz: Fusion of Peruvian and French cuisine.\n- Tree House Restaurant: Offers a diverse menu with local ingredients.\n- Café Inkaterra: Upscale dining with a focus on organic produce.\n- Mapacho Craft Beer & Peruvian Cuisine: Combines local dishes with craft beers.\n\nAverage Prices:\n- Budget meals: $3–$10\n- Mid-range: $10–$25\n- High-end: $30–$40";

        objs1[3].transportation = "Getting to Machu Picchu:\n- Train: The primary mode of transportation is by train from Cusco or Ollantaytambo to Aguas Calientes.\n- Bus: From Aguas Calientes, ecological buses take visitors up to the Machu Picchu entrance.\n- Hiking: The Inca Trail and Salkantay Trek are popular multi-day hiking routes to reach Machu Picchu.\n\nLocal Transport:\n- Aguas Calientes is a pedestrian-only town; walking is the main mode of transport.";

        objs1[3].shopping = "Shopping in Aguas Calientes:\n- Machu Picchu Market: Offers a variety of souvenirs, including textiles, alpaca products, and handicrafts.\n- Local Shops: Sell items like handmade jewelry, ceramics, and traditional clothing.\n\nPopular Souvenirs:\n- Alpaca wool clothing\n- Handwoven textiles\n- Peruvian coffee and chocolate\n- Pisco bottles";

        objs1[3].importantPlaces = "Nearby Attractions:\n- Huayna Picchu: Mountain offering panoramic views of Machu Picchu.\n- Mandor Gardens: Botanical gardens with waterfalls and diverse flora.\n- Aguas Calientes Hot Springs: Natural hot springs ideal for relaxation.\n- Manuel Chávez Ballón Museum: Provides historical context about Machu Picchu.";

        objs1[3].rooms = "Accommodation Options:\nLuxury:\n- Belmond Sanctuary Lodge: The only hotel adjacent to Machu Picchu.\n- Inkaterra Machu Picchu Pueblo Hotel: Eco-friendly hotel with lush gardens.\n\nMid-Range:\n- Tierra Viva Machu Picchu: Comfortable rooms near the train station.\n- Casa Andina Standard: Offers modern amenities and river views.\n\nBudget:\n- Supertramp Hostel: Popular among backpackers for its vibrant atmosphere.\n- Hotel Wiracocha Inn: Affordable lodging with basic amenities.";


        objs1[4].locations = "General Information About the Colosseum\n\nThe Colosseum, also known as the Flavian Amphitheatre, is an ancient Roman amphitheater located in the center of Rome, Italy. Construction began under Emperor Vespasian in AD 72 and was completed in AD 80 under his successor, Titus. The Colosseum could hold between 50,000 to 80,000 spectators and was used for gladiatorial contests, public spectacles, animal hunts, and dramas based on Classical mythology.\n\nVisiting Hours: The Colosseum is open daily from 8:30 AM, with closing times varying by season:\n- January 2 to March 29: Closes at 4:30 PM\n- March 30 to September 30: Closes at 7:15 PM\n- October 1 to October 26: Closes at 6:30 PM\n- October 27 to December 31: Closes at 4:30 PM\nLast admission is one hour before closing. The Colosseum is closed on January 1st and December 25th.\n\nBest Time to Visit: To avoid large crowds, it's recommended to visit early in the morning around 8:30 AM or later in the afternoon before closing time. Mid-week visits during the off-peak season (October to March) also tend to be less crowded.";

        objs1[4].food = "Foods to Try:\n- Carbonara: Pasta with eggs, cheese, pancetta, and pepper.\n- Supplì: Fried rice balls with mozzarella filling.\n- Saltimbocca: Veal wrapped with prosciutto and sage.\n- Gelato: Traditional Italian ice cream in various flavors.\n\nPopular Restaurants:\n- Trattoria Luzzi: Known for authentic Roman dishes at reasonable prices.\n- Ristorante Aroma: Offers gourmet dining with Colosseum views.\n- Pizzeria Li Rioni: Famous for wood-fired pizzas.\n- Osteria da Fortunata: Handmade pasta specialties.\n\nAverage Prices:\n- Budget meals: €10–€15\n- Mid-range: €20–€35\n- High-end: €50 and above";

        objs1[4].transportation = "Getting to the Colosseum:\n- Metro: Line B (Blue Line) to Colosseo station.\n- Bus: Lines 51, 75, 85, 87, and 118 have stops near the Colosseum.\n- Tram: Line 3 stops close to the site.\n\nFrom Airports:\n- Fiumicino Airport: Train to Termini Station, then Metro Line B.\n- Ciampino Airport: Bus to Termini Station, then Metro Line B.";

        objs1[4].shopping = "Shopping Near the Colosseum:\n- Via del Corso: Popular shopping street with various retail stores.\n- Via dei Condotti: High-end boutiques featuring luxury brands.\n- Local Souvenir Shops: Offer items like miniature Colosseums, Roman helmets, and postcards.\n\nMarkets:\n- Campo de' Fiori: Open-air market selling food, flowers, and souvenirs.\n- Porta Portese: Rome's largest flea market, open on Sundays.";

        objs1[4].importantPlaces = "Nearby Attractions:\n- Roman Forum: Ruins of ancient government buildings.\n- Palatine Hill: Offers views of the Forum and Circus Maximus.\n- Arch of Constantine: Triumphal arch situated between the Colosseum and Palatine Hill.\n- Capitoline Museums: Houses a vast collection of art and artifacts.\n- Basilica di San Clemente: A multi-layered church with underground ruins.";

        objs1[4].rooms = "Accommodation Options:\nLuxury:\n- Hotel Palazzo Manfredi: Offers suites with direct views of the Colosseum.\n- The Inn at the Roman Forum: Boutique hotel with ancient ruins inside.\n\nMid-Range:\n- Hotel Capo d'Africa: Modern hotel a short walk from the Colosseum.\n- Mercure Roma Centro Colosseo: Features a rooftop pool with Colosseum views.\n\nBudget:\n- Hotel Celio: Charming hotel with a vintage feel.\n- B&B Santi Quattro Al Colosseo: Affordable rooms with a homey atmosphere.";


        objs1[5].locations = "General Information About Christ the Redeemer\n\nChrist the Redeemer (Cristo Redentor) is an iconic Art Deco statue of Jesus Christ located atop Corcovado Mountain in Rio de Janeiro, Brazil. Standing 30 meters tall (98 feet), with arms stretching 28 meters (92 feet) wide, it overlooks the city and is considered a symbol of Christianity across the world. The statue is situated within the Tijuca National Park, offering panoramic views of Rio's beaches, mountains, and urban landscape.\n\nVisiting Hours: Open daily from 8:00 AM to 6:00 PM. \n\nBest Time to Visit: Early morning around 8:00 AM to avoid crowds and enjoy optimal lighting for photography.";

        objs1[5].food = "Foods to Try:\n- Feijoada: A hearty stew of black beans with pork, traditionally served with rice and orange slices.\n- Pão de Queijo: Chewy cheese bread made from tapioca flour.\n- Moqueca: A flavorful fish stew cooked with coconut milk, tomatoes, and dendê oil.\n\nPopular Restaurants:\n- Restaurante Corcovado: Located on Corcovado Mountain, offering traditional Brazilian dishes.\n- Aconchego Carioca: Known for its feijoada and other regional specialties.\n- Bar Simplesmente: Offers generous portions of Brazilian cuisine at affordable prices.\n\nAverage Prices: Mid-range restaurants typically charge between R$100 to R$200 per person for a three-course meal.";

        objs1[5].transportation = "Getting to Christ the Redeemer:\n- Official Vans: Depart from locations such as Copacabana (Praça do Lido), Largo do Machado, and Barra da Tijuca, with tickets including entrance fees.\n- Corcovado Train: A scenic railway that takes visitors through the Tijuca Forest to the summit.\n- Taxis and Ride-Sharing: Services like Uber are readily available throughout Rio.\n- Public Buses: Various lines connect to the base of Corcovado Mountain.";

        objs1[5].shopping = "Shopping Near Christ the Redeemer:\n- Paineiras Visitors' Center: Offers a variety of souvenirs, including T-shirts, mugs, and local crafts.\n- Shopping Rio Sul: A large mall featuring national and international brands.\n- Saara Market: A bustling market area known for affordable clothing, accessories, and souvenirs.";

        objs1[5].importantPlaces = "Nearby Attractions:\n- Sugarloaf Mountain (Pão de Açúcar): Offers cable car rides and panoramic views of Rio.\n- Tijuca National Park: A vast urban rainforest with hiking trails and waterfalls.\n- Selarón Steps (Escadaria Selarón): A colorful mosaic staircase created by artist Jorge Selarón.\n- Copacabana and Ipanema Beaches: Famous beaches known for their vibrant atmosphere.";

        objs1[5].rooms = "Accommodation Options:\nLuxury:\n- Copacabana Palace, A Belmond Hotel: A historic hotel offering luxury amenities and ocean views.\n- Hilton Copacabana Rio de Janeiro: A beachfront hotel with modern facilities.\n\nMid-Range:\n- Les Jardins de Rio: A boutique hotel located near the Corcovado Mountain.\n- Casa Caminho do Corcovado: Offers comfortable accommodations close to the statue.\n\nBudget:\n- JO&JOE Rio de Janeiro: A hostel with a vibrant atmosphere and affordable rates.\n- Farfalla Guest House: Provides budget-friendly rooms in a convenient location.";


        objs1[6].locations = "General Information About the Pyramids of Giza\n\nThe Pyramids of Giza, located on the Giza Plateau near Cairo, Egypt, are ancient monuments built during the Fourth Dynasty of the Old Kingdom. The complex includes three main pyramids: the Great Pyramid of Khufu, the Pyramid of Khafre, and the Pyramid of Menkaure, along with the Great Sphinx and several smaller pyramids and tombs. These structures are considered one of the Seven Wonders of the Ancient World.\n\nVisiting Hours: Open daily from 8:00 AM to 4:00 PM (October to March) and from 7:00 AM to 6:00 PM (April to September).\n\nBest Time to Visit: Early morning visits are recommended to avoid crowds and the midday heat.";

        objs1[6].food = "Foods to Try:\n- Koshari: A traditional Egyptian dish made with rice, lentils, pasta, and tomato sauce.\n- Ful Medames: Stewed fava beans seasoned with olive oil, garlic, and lemon juice.\n- Molokhia: A green leafy soup made from jute leaves, often served with meat and rice.\n\nPopular Restaurants:\n- Restaurant El Dar Darak: Offers Middle Eastern and Egyptian cuisine near the pyramids.\n- Safary 2000: Known for its local dishes and proximity to the Giza Plateau.\n- Zoe Restaurant: Serves Mediterranean and healthy options with views of the pyramids.\n\nAverage Prices: Meals at mid-range restaurants range from EGP 600 to EGP 900 per person.";

        objs1[6].transportation = "Getting to the Pyramids of Giza:\n- Taxis and Ride-Sharing: Services like Uber and Careem are available in Cairo and Giza.\n- Public Buses: Several bus lines connect Cairo to Giza, with stops near the pyramids.\n- Metro: The Cairo Metro does not extend directly to the pyramids, but nearby stations can be used in conjunction with taxis.\n- Tour Packages: Many companies offer guided tours with transportation included.";

        objs1[6].shopping = "Shopping Near the Pyramids:\n- Khan El Khalili Bazaar: A famous market in Cairo offering souvenirs, spices, jewelry, and traditional crafts.\n- Local Shops: Numerous vendors near the pyramids sell papyrus paintings, miniature pyramids, and other souvenirs.\n- Modern Malls: City Stars and Mall of Egypt offer a range of international and local brands.";

        objs1[6].importantPlaces = "Nearby Attractions:\n- Grand Egyptian Museum: A new museum near the Giza Plateau housing a vast collection of ancient artifacts.\n- Saqqara: Home to the Step Pyramid of Djoser, one of the earliest pyramids built in Egypt.\n- Memphis: The ancient capital of Egypt, featuring ruins and statues, including a massive statue of Ramses II.\n- Solar Boat Museum: Displays the reconstructed Khufu ship, an ancient vessel buried near the Great Pyramid.";

        objs1[6].rooms = "Accommodation Options:\nLuxury:\n- Marriott Mena House: A historic hotel offering views of the pyramids and luxurious amenities.\n- Four Seasons Hotel Cairo at Nile Plaza: Located in Cairo with high-end facilities.\n\nMid-Range:\n- Pyramids View Inn: Offers comfortable rooms with direct views of the pyramids.\n- Giza Pyramids Inn: Provides modern accommodations near the Giza Plateau.\n\nBudget:\n- Guardian Guest House: A budget-friendly option with pyramid views.\n- Sphinx Guest House: Offers basic amenities and proximity to the pyramids.";


        objs1[7].locations = "General Information About the Sydney Opera House\n\nThe Sydney Opera House is a multi-venue performing arts center located on Bennelong Point in Sydney Harbour, Australia. Designed by Danish architect Jørn Utzon, its construction began in 1959 and was completed in 1973. The building is renowned for its distinctive sail-like design and is considered a masterpiece of 20th-century architecture. It was designated a UNESCO World Heritage Site in 2007.\n\nVisiting Hours: The Opera House is open daily from 9:00 AM to 5:00 PM. Guided tours are available in multiple languages, and performance schedules vary by event.\n\nBest Time to Visit: October, November, late February, and March offer pleasant weather and fewer crowds, making them ideal months for a visit.";

        objs1[7].food = "Foods to Try:\n- Barramundi: A popular Australian fish, often grilled or pan-fried.\n- Meat Pie: A traditional Australian savory pie filled with minced meat and gravy.\n- Lamingtons: Sponge cake squares coated in chocolate and desiccated coconut.\n\nPopular Restaurants:\n- Bennelong Restaurant: Located within the Opera House, offering contemporary Australian cuisine.\n- Opera Bar: A casual dining spot with views of the harbor, serving a variety of dishes and drinks.\n- Portside Sydney: Offers modern Australian dishes with indoor and outdoor seating options.";

        objs1[7].transportation = "Getting Around Sydney:\n- Trains: Circular Quay Station is the nearest train station to the Opera House.\n- Ferries: Circular Quay Ferry Terminal provides access to various parts of Sydney via ferry.\n- Buses: Multiple bus routes stop at Circular Quay, a short walk from the Opera House.\n- Walking: The Opera House is easily accessible on foot from many parts of the city center.";

        objs1[7].shopping = "Shopping Near the Sydney Opera House:\n- The Rocks Markets: Offers a variety of local crafts, souvenirs, and food stalls.\n- Pitt Street Mall: A major shopping area featuring international and Australian brands.\n- Queen Victoria Building: A historic shopping center with boutique stores and cafes.";

        objs1[7].importantPlaces = "Nearby Attractions:\n- Royal Botanic Garden: Adjacent to the Opera House, offering scenic walks and diverse plant collections.\n- Sydney Harbour Bridge: An iconic bridge offering pedestrian walkways and bridge climb experiences.\n- Museum of Contemporary Art Australia: Showcases contemporary artworks by Australian and international artists.";

        objs1[7].rooms = "Accommodation Options:\nLuxury:\n- Park Hyatt Sydney: Offers luxury rooms with views of the Opera House and Harbour Bridge.\n- Four Seasons Hotel Sydney: Located near Circular Quay, providing upscale amenities.\n\nMid-Range:\n- Radisson Blu Plaza Hotel Sydney: A heritage-listed hotel with modern facilities.\n- The Fullerton Hotel Sydney: Combines classic architecture with contemporary accommodations.\n\nBudget:\n- YHA Sydney Harbour: A budget-friendly hostel with rooftop views of the harbor.\n- Travelodge Hotel Sydney Wynyard: Offers comfortable rooms at affordable rates.";


        objs1[8].locations = "General Information About the Statue of Liberty\n\nThe Statue of Liberty, located on Liberty Island in New York Harbor, is a colossal neoclassical sculpture gifted by France to the United States. Designed by Frédéric Auguste Bartholdi and dedicated on October 28, 1886, it symbolizes freedom and democracy. The statue stands at 305 feet (93 meters) from the ground to the tip of the torch.\n\nVisiting Hours: Ferries to Liberty Island operate daily from 9:00 AM to 4:30 PM. The island and its attractions close around 5:00 PM. Access to the crown requires advance reservations.\n\nBest Time to Visit: Early mornings, especially on weekdays during spring (April to June) and fall (September to November), offer fewer crowds and pleasant weather.";

        objs1[8].food = "Foods to Try:\n- New York-style Pizza: Thin-crust pizza slices available throughout the city.\n- Bagels with Lox: Traditional New York bagels topped with smoked salmon and cream cheese.\n- Pretzels: Soft pretzels sold by street vendors, a classic New York snack.\n\nDining Options on Liberty Island:\n- Crown Café: Offers a variety of meals, snacks, and beverages for visitors.\n- Picnic Areas: Visitors can bring their own food and enjoy picnics with views of the statue.";

        objs1[8].transportation = "Getting to the Statue of Liberty:\n- Ferries: Operated by Statue City Cruises, ferries depart from Battery Park in Manhattan and Liberty State Park in New Jersey.\n- Subways: The 1 train to South Ferry, 4/5 trains to Bowling Green, and R/W trains to Whitehall Street provide access to Battery Park.\n- Buses: Several bus routes stop near Battery Park, including M5, M15, and M20.";

        objs1[8].shopping = "Shopping Near the Statue of Liberty:\n- Liberty Island Gift Shop: Offers souvenirs, books, and memorabilia related to the statue.\n- Ellis Island Gift Shop: Features items focused on immigration history and the Ellis Island experience.\n- Battery Park Vendors: Various stalls and shops near the ferry departure points sell souvenirs and snacks.";

        objs1[8].importantPlaces = "Nearby Attractions:\n- Ellis Island National Museum of Immigration: Chronicles the history of American immigration.\n- Battery Park: A waterfront park in Manhattan offering gardens, monuments, and harbor views.\n- Wall Street: The financial district of New York City, home to the New York Stock Exchange.";

        objs1[8].rooms = "Accommodation Options:\nLuxury:\n- The Ritz-Carlton New York, Battery Park: Offers rooms with views of the Statue of Liberty.\n- Conrad New York Downtown: A modern hotel located near the World Trade Center.\n\nMid-Range:\n- Hilton Garden Inn NYC Financial Center: Conveniently located near Battery Park.\n- DoubleTree by Hilton Hotel New York Downtown: Offers comfortable accommodations in the financial district.\n\nBudget:\n- Holiday Inn Manhattan-Financial District: Affordable rooms close to major attractions.\n- The Wall Street Inn: A charming hotel offering budget-friendly rates in a historic setting.";


    }



    public void OnStart()
    {
        _MainMenu.SetActive(false);
        _LocationsMenu.SetActive(true);
    }

    public void OnCredit()
    {
        _MainMenu.SetActive(false);
        _Credits.SetActive(true);
    }

    public void OnExit()
    {
        Application.Quit();
    }

    public void OnBack()
    {
        _MainMenu.SetActive(true);
        _Credits.SetActive(false);
        _LocationsMenu.SetActive(false);
        _Location_PLayer.Stop();
    }

    public void OnCloseLocationGuidance()
    {
        _LocationGuidance.SetActive(false);
        _Location_PLayer.Play();
    }

    public void Locations(GameObject ButtonName)
    {
        int ButtonNumber = int.Parse(ButtonName.name);
        locationNum = ButtonNumber;
        _LocationsMenu.SetActive(false);

        _Location_PLayer.clip = _Location_Videos[ButtonNumber - 1];
        _Location_PLayer.Play(); 

    }

    public void TripPlanner()
    {
        _LocationGuidance.SetActive(false);
        _TripPlanner.SetActive(true);
    }

    public void Update()
    {
     
    }

    public void LocationGuidanceInteraction()
    {
        _Location_PLayer.Stop();
        _LocationGuidance.SetActive(true);
    }

    public void LocationGuidanceClose()
    {
        _Location_PLayer.Stop();
        _LocationsMenu.SetActive(true);
    }

    public void FoodInfo()
    {
        Information.text = "" + objs1[locationNum-1].food;

    }

    public void RoomInfo()
    {
        Information.text = "" + objs1[locationNum - 1].rooms;

    }

    public void ImportantPlacesInfo()
    {
        Information.text = "" + objs1[locationNum - 1].importantPlaces;

    }

    public void ShoppingInfo()
    {
        Information.text = "" + objs1[locationNum - 1].shopping;

    }

    public void TransportationInfo()
    {
        Information.text = "" + objs1[locationNum - 1].transportation;

    }

    public void LocationInfo()
    {
        Information.text = "" + objs1[locationNum - 1].locations;

    }


    // called by Room icon OnClick:
    public void ShowRooms()
    {
        _TripPlanner.SetActive(false);
        RoomSelect.SetActive(true);
        
    }

    // same pattern for the others:
    public void ShowShopping()
    {
        _TripPlanner.SetActive(false);
        ShoppingSelect.SetActive(true);
        
    }

    public void ShowTransport()
    {
        _TripPlanner.SetActive(false);
        TransportSelect.SetActive(true);
        
    }

    public void ShowFood()
    {
        _TripPlanner.SetActive(false);
        FoodSelect.SetActive(true);
    }


    public void RoomSelectPageClose()
    {
        RoomSelect.SetActive(false);
        TripPlannerPage.SetActive(true);
    }

}
