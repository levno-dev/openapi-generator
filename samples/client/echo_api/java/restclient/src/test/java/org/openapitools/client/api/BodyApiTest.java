/*
 * Echo Server API
 * Echo Server API
 *
 * The version of the OpenAPI document: 0.1.0
 * Contact: team@openapitools.org
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

package org.openapitools.client.api;

import static org.hamcrest.CoreMatchers.containsString;
import static org.hamcrest.CoreMatchers.is;
import static org.hamcrest.CoreMatchers.notNullValue;
import static org.hamcrest.CoreMatchers.nullValue;
import static org.hamcrest.MatcherAssert.assertThat;

import java.io.File;
import java.io.IOException;
import java.nio.file.Files;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import org.junit.Test;
import org.openapitools.client.ApiClient;
import org.openapitools.client.GifHttpMessageConverter;
import org.openapitools.client.OctetStreamHttpMessageConverter;
import org.openapitools.client.model.Category;
import org.openapitools.client.model.Pet;
import org.openapitools.client.model.Pet.StatusEnum;
import org.openapitools.client.model.StringEnumRef;
import org.openapitools.client.model.Tag;

/** API tests for BodyApi */
public class BodyApiTest {

  private final BodyApi api = new BodyApi();

  /**
   * Test binary (gif) response body
   *
   * <p>Test binary (gif) response body
   */
  @Test
  public void testBinaryGifTest() throws IOException {
    // given
    var restClient =
        ApiClient.buildRestClientBuilder()
            .messageConverters(converters -> converters.add(new GifHttpMessageConverter()))
            .build();
    api.setApiClient(new ApiClient(restClient));

    // when
    File response = api.testBinaryGif();

    // then
    assertThat(response, notNullValue());
    assertThat(response.exists(), is(true));
    assertThat(Files.probeContentType(response.toPath()), is("image/gif"));
  }

  /**
   * Test body parameter(s)
   *
   * <p>Test body parameter(s)
   */
  @Test
  public void testBodyApplicationOctetstreamBinaryTest() throws IOException {
    // given
    var restClient =
        ApiClient.buildRestClientBuilder()
            .messageConverters(converters -> converters.add(new OctetStreamHttpMessageConverter()))
            .build();
    api.setApiClient(new ApiClient(restClient));

    var tempFile = Files.createTempFile("test", ".txt");
    Files.writeString(tempFile, "test123");

    File body = tempFile.toFile();

    // when
    String response = api.testBodyApplicationOctetstreamBinary(body);

    // then
    assertThat(response, containsString("Content-Type: application/octet-stream"));
    assertThat(response, containsString("test123"));
  }

  /**
   * Test array of binary in multipart mime
   *
   * <p>Test array of binary in multipart mime
   */
  @Test
  public void testBodyMultipartFormdataArrayOfBinaryTest() throws IOException {
    // given
    var firstFile = Files.createTempFile("test", ".txt");
    String firstFileContent = "Thanks for using OpenAPI generator :)";
    Files.writeString(firstFile, firstFileContent);

    var secondFile = Files.createTempFile("test2", ".txt");
    String secondFileContent = "Your ad could be here";
    Files.writeString(secondFile, secondFileContent);

    List<File> files = List.of(firstFile.toFile(), secondFile.toFile());

    // when
    String response = api.testBodyMultipartFormdataArrayOfBinary(files);

    // then
    assertThat(response, containsString("Content-Type: multipart/form-data"));
    assertThat(response, containsString(firstFileContent));
    assertThat(response, containsString(secondFileContent));
  }

  /**
   * Test single binary in multipart mime
   *
   * <p>Test single binary in multipart mime
   */
  @Test
  public void testBodyMultipartFormdataSingleBinaryTest() throws IOException {
    // given
    var testFile = Files.createTempFile("test", ".txt");
    String testFileContent = "Lorem ipsum dolor sit amet";
    Files.writeString(testFile, testFileContent);

    // when
    String response = api.testBodyMultipartFormdataSingleBinary(testFile.toFile());

    // then
    assertThat(response, containsString("Content-Type: multipart/form-data"));
    assertThat(response, containsString(testFileContent));
  }

  /**
   * Test body parameter(s)
   *
   * <p>Test body parameter(s)
   */
  @Test
  public void testEchoBodyAllOfPetTest() {
    // given
    // The content length must be set to disable the Transfer-Encoding: chunked which would lead to
    // unparsable response because the echo server is replying them as body.
    api.getApiClient().addDefaultHeader("Content-Length", "192");

    Pet pet =
        new Pet()
            .id(42L)
            .name("Corgi")
            .category(new Category().id(1L).name("Dogs"))
            .status(StatusEnum.SOLD)
            .addPhotoUrlsItem(
                "https://cdn.pixabay.com/photo/2021/10/13/09/01/corgi-6705821_1280.jpg")
            .addTagsItem(new Tag().id(1L).name("cute"));

    // when
    Pet response = api.testEchoBodyAllOfPet(pet);

    // then
    assertThat(response, is(pet));
  }

  /**
   * Test free form object
   *
   * <p>Test free form object
   */
  @Test
  public void testEchoBodyFreeFormObjectResponseStringTest() {
    // given
    // The content length must be set to disable the Transfer-Encoding: chunked which would lead to
    // unparsable response because the echo server is replying them as body.
    api.getApiClient().addDefaultHeader("Content-Length", "51");

    Object mapAsObject =
        new HashMap<>(
            Map.of(
                "firstKey", "firstValue",
                "secondKey", "secondValue"));

    // when
    String response = api.testEchoBodyFreeFormObjectResponseString(mapAsObject);

    // then
    assertThat(response, is("{\"firstKey\":\"firstValue\",\"secondKey\":\"secondValue\"}"));
  }

  /**
   * Test body parameter(s)
   *
   * <p>Test body parameter(s)
   */
  @Test
  public void testEchoBodyPetTest() {
    // given
    // The content length must be set to disable the Transfer-Encoding: chunked which would lead to
    // unparsable response because the echo server is replying them as body.
    api.getApiClient().addDefaultHeader("Content-Length", "192");

    Pet pet =
        new Pet()
            .id(42L)
            .name("Corgi")
            .category(new Category().id(1L).name("Dogs"))
            .status(StatusEnum.SOLD)
            .addPhotoUrlsItem(
                "https://cdn.pixabay.com/photo/2021/10/13/09/01/corgi-6705821_1280.jpg")
            .addTagsItem(new Tag().id(1L).name("cute"));

    // when
    Pet response = api.testEchoBodyPet(pet);

    // then
    assertThat(response, is(pet));
  }

  /**
   * Test empty response body
   *
   * <p>Test empty response body
   */
  @Test
  public void testEchoBodyPetResponseStringTest() {
    // given
    // The content length must be set to disable the Transfer-Encoding: chunked which would lead to
    // unparsable response because the echo server is replying them as body.
    api.getApiClient().addDefaultHeader("Content-Length", "192");

    Pet pet =
        new Pet()
            .id(42L)
            .name("Corgi")
            .category(new Category().id(1L).name("Dogs"))
            .status(StatusEnum.SOLD)
            .addPhotoUrlsItem(
                "https://cdn.pixabay.com/photo/2021/10/13/09/01/corgi-6705821_1280.jpg")
            .addTagsItem(new Tag().id(1L).name("cute"));

    // when
    String response = api.testEchoBodyPetResponseString(pet);

    // then
    assertThat(
        response,
        is(
            "{\"id\":42,\"name\":\"Corgi\",\"category\":{\"id\":1,\"name\":\"Dogs\"},\"photoUrls\":[\"https://cdn.pixabay.com/photo/2021/10/13/09/01/corgi-6705821_1280.jpg\"],\"tags\":[{\"id\":1,\"name\":\"cute\"}],\"status\":\"sold\"}"));
  }

  /**
   * Test string enum response body
   *
   * <p>Test string enum response body
   */
  @Test
  public void testEchoBodyStringEnumTest() {
    // given
    String body = "\"failure\"";

    // when
    StringEnumRef response = api.testEchoBodyStringEnum(body);

    // then
    assertThat(response, is(StringEnumRef.FAILURE));
  }

  /**
   * Test empty json (request body)
   *
   * <p>Test empty json (request body)
   */
  @Test
  public void testEchoBodyTagResponseStringTest() {
    // given
    Tag tag = null;

    // when
    String response = api.testEchoBodyTagResponseString(tag);

    // then
    assertThat(response, nullValue());
  }
}
