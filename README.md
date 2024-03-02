# Sitecore Hackathon 2024

## Team name
⟹ SRS

## Category
⟹ Best use of AI

## Description
⟹ Azure Computer Vision for Sitecore media library  

  - Azure Computer Vision seamlessly integrates with Sitecore's media library, automating the tagging of images. Leveraging advanced image analysis, it enhances content organization and searchability. This integration streamlines content management, providing efficient categorization for improved user experiences.

## Video link
⟹ [https://www.youtube.com/](https://youtu.be/0h2ZYV6RVrM?si=ZFZzfnVbIAfqqeUX)

## Pre-requisites and Dependencies

⟹ Download and install our Sitecore package
⟹ Activate Azure Computer Vision service
⟹ Open Uploadmedia.config file and update your uriBase and subscriptionKey key
	  <setting name="uriBase" value="Azure Api URL"/>
      <setting name="subscriptionKey" value="Azure Api Key"/>


## Installation instructions

> - Go to Development Tools -> Installation Wizard.
> - Upload the .zip package.
> - Click on Install and wait for the installation process to finish.
> - Restart the Sitecore client after installation is finished


### Configuration
⟹ Open Uploadmedia.config file and update your uriBase and subscriptionKey key
	  <setting name="uriBase" value="Azure Api URL"/>
      <setting name="subscriptionKey" value="Azure Api Key"/>


## Usage instructions

1. Login to Sitecore.
2. Click on Content Editor.
3. Visit any folder in “/sitecore/media library/”.
4. Upload the image.
5. Tags will be automatically added to image item in Tagging -> Semantics section.
