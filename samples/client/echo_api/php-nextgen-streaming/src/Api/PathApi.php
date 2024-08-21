<?php
/**
 * PathApi
 * PHP version 8.1
 *
 * @package  OpenAPI\Client
 * @author   OpenAPI Generator team
 * @link     https://openapi-generator.tech
 */

/**
 * Echo Server API
 *
 * Echo Server API
 *
 * The version of the OpenAPI document: 0.1.0
 * Contact: team@openapitools.org
 * @generated Generated by: https://openapi-generator.tech
 * Generator version: 7.9.0-SNAPSHOT
 */

/**
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

namespace OpenAPI\Client\Api;

use InvalidArgumentException;
use GuzzleHttp\Client;
use GuzzleHttp\ClientInterface;
use GuzzleHttp\Exception\ConnectException;
use GuzzleHttp\Exception\RequestException;
use GuzzleHttp\Psr7\MultipartStream;
use GuzzleHttp\Psr7\Request;
use GuzzleHttp\RequestOptions;
use GuzzleHttp\Promise\PromiseInterface;
use OpenAPI\Client\ApiException;
use OpenAPI\Client\Configuration;
use OpenAPI\Client\HeaderSelector;
use OpenAPI\Client\ObjectSerializer;

/**
 * PathApi Class Doc Comment
 *
 * @package  OpenAPI\Client
 * @author   OpenAPI Generator team
 * @link     https://openapi-generator.tech
 */
class PathApi
{
    /**
     * @var ClientInterface
     */
    protected ClientInterface $client;

    /**
     * @var Configuration
     */
    protected Configuration $config;

    /**
     * @var HeaderSelector
     */
    protected HeaderSelector $headerSelector;

    /**
     * @var int Host index
     */
    protected int $hostIndex;

    /** @var string[] $contentTypes **/
    public const contentTypes = [
        'testsPathStringPathStringIntegerPathIntegerEnumNonrefStringPathEnumRefStringPath' => [
            'application/json',
        ],
    ];

    /**
     * @param ClientInterface|null $client
     * @param Configuration|null   $config
     * @param HeaderSelector|null  $selector
     * @param int                  $hostIndex (Optional) host index to select the list of hosts if defined in the OpenAPI spec
     */
    public function __construct(
        ClientInterface $client = null,
        Configuration $config = null,
        HeaderSelector $selector = null,
        int $hostIndex = 0
    ) {
        $this->client = $client ?: new Client();
        $this->config = $config ?: new Configuration();
        $this->headerSelector = $selector ?: new HeaderSelector();
        $this->hostIndex = $hostIndex;
    }

    /**
     * Set the host index
     *
     * @param int $hostIndex Host index (required)
     */
    public function setHostIndex(int $hostIndex): void
    {
        $this->hostIndex = $hostIndex;
    }

    /**
     * Get the host index
     *
     * @return int Host index
     */
    public function getHostIndex(): int
    {
        return $this->hostIndex;
    }

    /**
     * @return Configuration
     */
    public function getConfig(): Configuration
    {
        return $this->config;
    }

    /**
     * Operation testsPathStringPathStringIntegerPathIntegerEnumNonrefStringPathEnumRefStringPath
     *
     * Test path parameter(s)
     *
     * @param  string $path_string path_string (required)
     * @param  int $path_integer path_integer (required)
     * @param  string $enum_nonref_string_path enum_nonref_string_path (required)
     * @param  StringEnumRef $enum_ref_string_path enum_ref_string_path (required)
     * @param  string $contentType The value for the Content-Type header. Check self::contentTypes['testsPathStringPathStringIntegerPathIntegerEnumNonrefStringPathEnumRefStringPath'] to see the possible values for this operation
     *
     * @throws ApiException on non-2xx response or if the response body is not in the expected format
     * @throws InvalidArgumentException
     * @return string
     */
    public function testsPathStringPathStringIntegerPathIntegerEnumNonrefStringPathEnumRefStringPath(
        string $path_string,
        int $path_integer,
        string $enum_nonref_string_path,
        StringEnumRef $enum_ref_string_path,
        string $contentType = self::contentTypes['testsPathStringPathStringIntegerPathIntegerEnumNonrefStringPathEnumRefStringPath'][0]
    ): string
    {
        list($response) = $this->testsPathStringPathStringIntegerPathIntegerEnumNonrefStringPathEnumRefStringPathWithHttpInfo($path_string, $path_integer, $enum_nonref_string_path, $enum_ref_string_path, $contentType);
        return $response;
    }

    /**
     * Operation testsPathStringPathStringIntegerPathIntegerEnumNonrefStringPathEnumRefStringPathWithHttpInfo
     *
     * Test path parameter(s)
     *
     * @param  string $path_string (required)
     * @param  int $path_integer (required)
     * @param  string $enum_nonref_string_path (required)
     * @param  StringEnumRef $enum_ref_string_path (required)
     * @param  string $contentType The value for the Content-Type header. Check self::contentTypes['testsPathStringPathStringIntegerPathIntegerEnumNonrefStringPathEnumRefStringPath'] to see the possible values for this operation
     *
     * @throws ApiException on non-2xx response or if the response body is not in the expected format
     * @throws InvalidArgumentException
     * @return array of string, HTTP status code, HTTP response headers (array of strings)
     */
    public function testsPathStringPathStringIntegerPathIntegerEnumNonrefStringPathEnumRefStringPathWithHttpInfo(
        string $path_string,
        int $path_integer,
        string $enum_nonref_string_path,
        StringEnumRef $enum_ref_string_path,
        string $contentType = self::contentTypes['testsPathStringPathStringIntegerPathIntegerEnumNonrefStringPathEnumRefStringPath'][0]
    ): array
    {
        $request = $this->testsPathStringPathStringIntegerPathIntegerEnumNonrefStringPathEnumRefStringPathRequest($path_string, $path_integer, $enum_nonref_string_path, $enum_ref_string_path, $contentType);

        try {
            $options = $this->createHttpClientOption();
            try {
                $response = $this->client->send($request, $options);
            } catch (RequestException $e) {
                throw new ApiException(
                    "[{$e->getCode()}] {$e->getMessage()}",
                    (int) $e->getCode(),
                    $e->getResponse() ? $e->getResponse()->getHeaders() : null,
                    $e->getResponse() ? (string) $e->getResponse()->getBody() : null
                );
            } catch (ConnectException $e) {
                throw new ApiException(
                    "[{$e->getCode()}] {$e->getMessage()}",
                    (int) $e->getCode(),
                    null,
                    null
                );
            }

            $statusCode = $response->getStatusCode();

            if ($statusCode < 200 || $statusCode > 299) {
                throw new ApiException(
                    sprintf(
                        '[%d] Error connecting to the API (%s)',
                        $statusCode,
                        (string) $request->getUri()
                    ),
                    $statusCode,
                    $response->getHeaders(),
                    (string) $response->getBody()
                );
            }

            switch($statusCode) {
                case 200:
                    if (in_array('string', ['\SplFileObject', '\Psr\Http\Message\StreamInterface'])) {
                        $content = $response->getBody(); //stream goes to serializer
                    } else {
                        $content = (string) $response->getBody();
                        if ('string' !== 'string') {
                            try {
                                $content = json_decode($content, false, 512, JSON_THROW_ON_ERROR);
                            } catch (\JsonException $exception) {
                                throw new ApiException(
                                    sprintf(
                                        'Error JSON decoding server response (%s)',
                                        $request->getUri()
                                    ),
                                    $statusCode,
                                    $response->getHeaders(),
                                    $content
                                );
                            }
                        }
                    }

                    return [
                        ObjectSerializer::deserialize($content, 'string', []),
                        $response->getStatusCode(),
                        $response->getHeaders()
                    ];
            }

            $returnType = 'string';
            if (in_array($returnType, ['\SplFileObject', '\Psr\Http\Message\StreamInterface'])) {
                $content = $response->getBody(); //stream goes to serializer
            } else {
                $content = (string) $response->getBody();
                if ($returnType !== 'string') {
                    try {
                        $content = json_decode($content, false, 512, JSON_THROW_ON_ERROR);
                    } catch (\JsonException $exception) {
                        throw new ApiException(
                            sprintf(
                                'Error JSON decoding server response (%s)',
                                $request->getUri()
                            ),
                            $statusCode,
                            $response->getHeaders(),
                            $content
                        );
                    }
                }
            }

            return [
                ObjectSerializer::deserialize($content, $returnType, []),
                $response->getStatusCode(),
                $response->getHeaders()
            ];

        } catch (ApiException $e) {
            switch ($e->getCode()) {
                case 200:
                    $data = ObjectSerializer::deserialize(
                        $e->getResponseBody(),
                        'string',
                        $e->getResponseHeaders()
                    );
                    $e->setResponseObject($data);
                    break;
            }
            throw $e;
        }
    }

    /**
     * Operation testsPathStringPathStringIntegerPathIntegerEnumNonrefStringPathEnumRefStringPathAsync
     *
     * Test path parameter(s)
     *
     * @param  string $path_string (required)
     * @param  int $path_integer (required)
     * @param  string $enum_nonref_string_path (required)
     * @param  StringEnumRef $enum_ref_string_path (required)
     * @param  string $contentType The value for the Content-Type header. Check self::contentTypes['testsPathStringPathStringIntegerPathIntegerEnumNonrefStringPathEnumRefStringPath'] to see the possible values for this operation
     *
     * @throws InvalidArgumentException
     * @return PromiseInterface
     */
    public function testsPathStringPathStringIntegerPathIntegerEnumNonrefStringPathEnumRefStringPathAsync(
        string $path_string,
        int $path_integer,
        string $enum_nonref_string_path,
        StringEnumRef $enum_ref_string_path,
        string $contentType = self::contentTypes['testsPathStringPathStringIntegerPathIntegerEnumNonrefStringPathEnumRefStringPath'][0]
    ): PromiseInterface
    {
        return $this->testsPathStringPathStringIntegerPathIntegerEnumNonrefStringPathEnumRefStringPathAsyncWithHttpInfo($path_string, $path_integer, $enum_nonref_string_path, $enum_ref_string_path, $contentType)
            ->then(
                function ($response) {
                    return $response[0];
                }
            );
    }

    /**
     * Operation testsPathStringPathStringIntegerPathIntegerEnumNonrefStringPathEnumRefStringPathAsyncWithHttpInfo
     *
     * Test path parameter(s)
     *
     * @param  string $path_string (required)
     * @param  int $path_integer (required)
     * @param  string $enum_nonref_string_path (required)
     * @param  StringEnumRef $enum_ref_string_path (required)
     * @param  string $contentType The value for the Content-Type header. Check self::contentTypes['testsPathStringPathStringIntegerPathIntegerEnumNonrefStringPathEnumRefStringPath'] to see the possible values for this operation
     *
     * @throws InvalidArgumentException
     * @return PromiseInterface
     */
    public function testsPathStringPathStringIntegerPathIntegerEnumNonrefStringPathEnumRefStringPathAsyncWithHttpInfo(
        $path_string,
        $path_integer,
        $enum_nonref_string_path,
        $enum_ref_string_path,
        string $contentType = self::contentTypes['testsPathStringPathStringIntegerPathIntegerEnumNonrefStringPathEnumRefStringPath'][0]
    ): PromiseInterface
    {
        $returnType = 'string';
        $request = $this->testsPathStringPathStringIntegerPathIntegerEnumNonrefStringPathEnumRefStringPathRequest($path_string, $path_integer, $enum_nonref_string_path, $enum_ref_string_path, $contentType);

        return $this->client
            ->sendAsync($request, $this->createHttpClientOption())
            ->then(
                function ($response) use ($returnType) {
                    if (in_array($returnType, ['\SplFileObject', '\Psr\Http\Message\StreamInterface'])) {
                        $content = $response->getBody(); //stream goes to serializer
                    } else {
                        $content = (string) $response->getBody();
                        if ($returnType !== 'string') {
                            $content = json_decode($content);
                        }
                    }

                    return [
                        ObjectSerializer::deserialize($content, $returnType, []),
                        $response->getStatusCode(),
                        $response->getHeaders()
                    ];
                },
                function ($exception) {
                    $response = $exception->getResponse();
                    $statusCode = $response->getStatusCode();
                    throw new ApiException(
                        sprintf(
                            '[%d] Error connecting to the API (%s)',
                            $statusCode,
                            $exception->getRequest()->getUri()
                        ),
                        $statusCode,
                        $response->getHeaders(),
                        (string) $response->getBody()
                    );
                }
            );
    }

    /**
     * Create request for operation 'testsPathStringPathStringIntegerPathIntegerEnumNonrefStringPathEnumRefStringPath'
     *
     * @param  string $path_string (required)
     * @param  int $path_integer (required)
     * @param  string $enum_nonref_string_path (required)
     * @param  StringEnumRef $enum_ref_string_path (required)
     * @param  string $contentType The value for the Content-Type header. Check self::contentTypes['testsPathStringPathStringIntegerPathIntegerEnumNonrefStringPathEnumRefStringPath'] to see the possible values for this operation
     *
     * @throws InvalidArgumentException
     * @return \GuzzleHttp\Psr7\Request
     */
    public function testsPathStringPathStringIntegerPathIntegerEnumNonrefStringPathEnumRefStringPathRequest(
        $path_string,
        $path_integer,
        $enum_nonref_string_path,
        $enum_ref_string_path,
        string $contentType = self::contentTypes['testsPathStringPathStringIntegerPathIntegerEnumNonrefStringPathEnumRefStringPath'][0]
    ): Request
    {

        // verify the required parameter 'path_string' is set
        if ($path_string === null || (is_array($path_string) && count($path_string) === 0)) {
            throw new InvalidArgumentException(
                'Missing the required parameter $path_string when calling testsPathStringPathStringIntegerPathIntegerEnumNonrefStringPathEnumRefStringPath'
            );
        }

        // verify the required parameter 'path_integer' is set
        if ($path_integer === null || (is_array($path_integer) && count($path_integer) === 0)) {
            throw new InvalidArgumentException(
                'Missing the required parameter $path_integer when calling testsPathStringPathStringIntegerPathIntegerEnumNonrefStringPathEnumRefStringPath'
            );
        }

        // verify the required parameter 'enum_nonref_string_path' is set
        if ($enum_nonref_string_path === null || (is_array($enum_nonref_string_path) && count($enum_nonref_string_path) === 0)) {
            throw new InvalidArgumentException(
                'Missing the required parameter $enum_nonref_string_path when calling testsPathStringPathStringIntegerPathIntegerEnumNonrefStringPathEnumRefStringPath'
            );
        }

        // verify the required parameter 'enum_ref_string_path' is set
        if ($enum_ref_string_path === null || (is_array($enum_ref_string_path) && count($enum_ref_string_path) === 0)) {
            throw new InvalidArgumentException(
                'Missing the required parameter $enum_ref_string_path when calling testsPathStringPathStringIntegerPathIntegerEnumNonrefStringPathEnumRefStringPath'
            );
        }


        $resourcePath = '/path/string/{path_string}/integer/{path_integer}/{enum_nonref_string_path}/{enum_ref_string_path}';
        $formParams = [];
        $queryParams = [];
        $headerParams = [];
        $httpBody = '';
        $multipart = false;



        // path params
        if ($path_string !== null) {
            $resourcePath = str_replace(
                '{' . 'path_string' . '}',
                ObjectSerializer::toPathValue($path_string),
                $resourcePath
            );
        }
        // path params
        if ($path_integer !== null) {
            $resourcePath = str_replace(
                '{' . 'path_integer' . '}',
                ObjectSerializer::toPathValue($path_integer),
                $resourcePath
            );
        }
        // path params
        if ($enum_nonref_string_path !== null) {
            $resourcePath = str_replace(
                '{' . 'enum_nonref_string_path' . '}',
                ObjectSerializer::toPathValue($enum_nonref_string_path),
                $resourcePath
            );
        }
        // path params
        if ($enum_ref_string_path !== null) {
            $resourcePath = str_replace(
                '{' . 'enum_ref_string_path' . '}',
                ObjectSerializer::toPathValue($enum_ref_string_path),
                $resourcePath
            );
        }


        $headers = $this->headerSelector->selectHeaders(
            ['text/plain', ],
            $contentType,
            $multipart
        );

        // for model (json/xml)
        if (count($formParams) > 0) {
            if ($multipart) {
                $multipartContents = [];
                foreach ($formParams as $formParamName => $formParamValue) {
                    $formParamValueItems = is_array($formParamValue) ? $formParamValue : [$formParamValue];
                    foreach ($formParamValueItems as $formParamValueItem) {
                        $multipartContents[] = [
                            'name' => $formParamName,
                            'contents' => $formParamValueItem
                        ];
                    }
                }
                // for HTTP post (form)
                $httpBody = new MultipartStream($multipartContents);

            } elseif (stripos($headers['Content-Type'], 'application/json') !== false) {
                # if Content-Type contains "application/json", json_encode the form parameters
                $httpBody = \GuzzleHttp\Utils::jsonEncode($formParams);
            } else {
                // for HTTP post (form)
                $httpBody = ObjectSerializer::buildQuery($formParams);
            }
        }


        $defaultHeaders = [];
        if ($this->config->getUserAgent()) {
            $defaultHeaders['User-Agent'] = $this->config->getUserAgent();
        }

        $headers = array_merge(
            $defaultHeaders,
            $headerParams,
            $headers
        );

        $operationHost = $this->config->getHost();
        $query = ObjectSerializer::buildQuery($queryParams);
        return new Request(
            'GET',
            $operationHost . $resourcePath . ($query ? "?{$query}" : ''),
            $headers,
            $httpBody
        );
    }

    /**
     * Create http client option
     *
     * @throws \RuntimeException on file opening failure
     * @return array of http client options
     */
    protected function createHttpClientOption(): array
    {
        $options = [];
        if ($this->config->getDebug()) {
            $options[RequestOptions::DEBUG] = fopen($this->config->getDebugFile(), 'a');
            if (!$options[RequestOptions::DEBUG]) {
                throw new \RuntimeException('Failed to open the debug file: ' . $this->config->getDebugFile());
            }
        }

        return $options;
    }
}
