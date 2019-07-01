# Slick Carousel for Sitecore Expereince Accelerator

This project adds a "Slick Carousel" component to the toolbox. 

Adding it to the page creates a placeholder to which you can add "Carousel Items." 

Each Carousel Item has a placeholder which you can add any other SXA Component to: Promo's, Rich Text, whatever you need.

Save after adding to reload the page and actually have the Carousel Activated. Should work it experience editor mode as well as preview.

The carousel itself support the SXA Grid. Modify settings through the "Component Properties". There are many other slick options that have been parameterized for easy configuration, including a 'additional options' parameter which can be filled with json parameters to fully configure slick's options as you see fit.

Enabling the Slick Feature on Site Creation or adding to the site, will add the component to the toolbox as well as attach the Slick Base Theme to your custom theme to make it function properly. Ensure you are using that custom theme, or manually add the "Slick Carousel" base theme to your theme to ensure the base scripts and styles work.

Currently using Slick 1.6, as there were some issues with experience editor with 1.8. Also note, "infinite" mode is disabled in experience editor, as that also breaks the experience editor functionality.
