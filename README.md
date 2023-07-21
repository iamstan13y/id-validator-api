# Zimbabwean ID Authenticity Checker API

This open source project provides an API for checking the authenticity of Zimbabwean ID numbers using the Modulo 23 ID Check Letter authentication method.

The idea for this project was inspired by a tweet from [@TeamPacheduZW](https://twitter.com/TeamPacheduZW) about how Zimbabwean IDs are checked for authenticity using the same method. We thought it would be useful to create an API for validating ID numbers that's easy to use and accessible to everyone.

## Why Check Zimbabwean IDs?

We know what you're thinking: "Why do I need to check Zimbabwean IDs?" Well, the truth is, you probably don't. But if you ever find yourself in Zimbabwe and need to verify the authenticity of an ID number, this API will come in handy!

## How It Works

The Modulo 23 ID Check Letter authentication method is a widely used method for validating Zimbabwean ID numbers. The method involves calculating the remainder of the first six digits of the ID number divided by 23, and then mapping the remainder to a letter. If the calculated letter matches the last letter of the ID number, the ID number is considered valid.

Our API takes an ID number as input and returns a `ZimbabweanIDValidationResult` object containing a boolean `IsValid` property and a string `Message` property based on the validation result.

## Getting Started

To use the API, simply make an HTTP request to the API endpoint with the ID number to validate as a query parameter. The API returns a `ZimbabweanIDValidationResult` object containing a boolean `IsValid` property and a string `Message` property based on the validation result.

## Contributing

We welcome contributions from the community to help improve this project! If you have an idea for a feature or improvement, please feel free to create a pull request or open an issue. And if you're not a developer, you can still contribute by spreading the word about our API!

## Acknowledgments

We would like to express our gratitude to [@TeamPacheduZW](https://twitter.com/TeamPacheduZW) for inspiring this project and bringing attention to the Modulo 23 ID Check Letter authentication method.

## License

This project is licensed under the [MIT License](LICENSE).

## Conclusion

We hope you find our Zimbabwean ID Authenticity Checker API useful and informative. And if you ever find yourself in Zimbabwe, make sure to validate those IDs!
