# Security Policy for Forza Horizon 5 - Lap Time Calculator

This document outlines the security practices and guidelines for the Forza Horizon 5 - Lap Time Calculator console application.

## Security Overview

The Lap Time Calculator is a simple console application that accepts user input and performs calculations based on that input. The primary security concern for this application is validating user input to prevent errors and unexpected behavior.

## Input Validation

The program uses a custom `ReadNumberWithLimit()` function to validate user input, ensuring that entered values are within a specified range. The function also handles invalid inputs without throwing exceptions, improving the application's error-handling capabilities.

## Safe Integer Parsing

The `ReadNumberWithLimit()` function uses `int.TryParse()` instead of `int.Parse()` to safely convert user input strings to integers. This approach prevents the application from throwing exceptions when users enter invalid numeric inputs.

## Best Practices

While the current security measures in the Lap Time Calculator are appropriate for its intended use as a simple console application, it's essential to follow security best practices for larger or more complex applications. These practices may include:

- Regularly reviewing and updating dependencies to ensure they are free of known security vulnerabilities.
- Implementing comprehensive input validation and sanitation to protect against injection attacks and other malicious input.
- Using encryption and secure storage methods for sensitive data.
- Following the principle of least privilege, granting users and processes only the necessary permissions to perform their tasks.
- Regularly auditing code for security vulnerabilities and applying patches promptly.

## Reporting Security Issues

If you discover any security vulnerabilities or have concerns about the Lap Time Calculator's security, please report them by opening an issue on the project's GitHub repository. Please provide as much information as possible, including steps to reproduce the issue and any relevant error messages or logs.

We take security issues seriously and will investigate and address them promptly.

## Version Support

|Version| Supported          |
| ----- | ------------------ |
| 3.0   | :white_check_mark: |
| 2.0   | :x:                |
| 1.0   | :x:                |