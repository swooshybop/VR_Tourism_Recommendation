# VR Tourism Recommendation APP

This is a **work-in-progress VR application** I'm building as I learn virtual reality development using Unity and the XR Interaction Toolkit. 
The goal of the project is to create an immersive and interactive tourism experience where users can explore various **Wonders of the World** in virtual reality and receive personalized travel recommendations.

---

## Project Overview

In this VR experience, the user begins in a central hub where they can choose from different world wonders. Upon selecting a location, the experience transitions to a **360° video** that provides a near-real-life view of a spot near the selected landmark.
Note: These 360 videos are **not included** in the GitHub repository due to file size limits.
In the future, the implementation may switch to a Cesium-based 3D world model because it has been difficult to find 360 videos that are free or a suitable price for me.

Once at the location, the user can:

- Press the **A button** on the **right controller** (tested on Quest 3) to view basic information about the selected location.
- Choose to **"Plan My Trip"**, which lets them input a budget and receive recommendations for:
  - Rooms
  - Food
  - Transportation
  - Shopping

Recommendations dynamically respond to the user’s budget, and prices update accordingly to simulate the planning of a real trip.

---

## Current Features

- Unity-based VR application using XR Interaction Toolkit
- Basic UI and teleportation-based navigation
- 360 video viewing (videos excluded from GitHub)
- Budget-based recommendation system (rooms, food, etc.)
- Scene switching and dynamic content display
- Tested on Meta Quest 3 using Unity XR Input

---

## Future Plans

- Replace 360° videos with **Cesium-based** real-world 3D terrain
- Add gesture-based UI or more intuitive controller input
- Improve asset quality and UI polish
- Possibly add location-based soundscapes or narration

---
