# TencentAI

Get your appid and key at https://ai.qq.com/console/home

And replace in Constant.cs, then you can call api like


Word Position Tagging
var resTencentPosTag = await TencentAIHelper.WordPositionTagging("Your text here");

Word Proper Nouns
var resTencentProperNouns = await TencentAIHelper.WordProperNouns("Your text here");

Word Component
var resTencentComponent = await TencentAIHelper.WordComponent("Your text here");

Word Emotion Polar
var resTencentEmotionPolar = await TencentAIHelper.WordEmotionPolar("Your text here");


This repo also contains OCR and face recognition api.
