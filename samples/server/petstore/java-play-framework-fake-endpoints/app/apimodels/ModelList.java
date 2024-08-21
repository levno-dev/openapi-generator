package apimodels;

import com.fasterxml.jackson.annotation.JsonTypeName;
import com.fasterxml.jackson.annotation.*;
import java.util.Set;
import javax.validation.*;
import java.util.Objects;
import javax.validation.constraints.*;
import javax.validation.Valid;
/**
 * ModelList
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaPlayFrameworkCodegen", comments = "Generator version: 7.9.0-SNAPSHOT")
@SuppressWarnings({"UnusedReturnValue", "WeakerAccess"})
public class ModelList   {
  @JsonProperty("123-list")
  
  private String _123list;

  public ModelList _123list(String _123list) {
    this._123list = _123list;
    return this;
  }

   /**
   * Get _123list
   * @return _123list
  **/
  public String get123list() {
    return _123list;
  }

  public void set123list(String _123list) {
    this._123list = _123list;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ModelList _list = (ModelList) o;
    return Objects.equals(_123list, _list._123list);
  }

  @Override
  public int hashCode() {
    return Objects.hash(_123list);
  }

  @SuppressWarnings("StringBufferReplaceableByString")
  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ModelList {\n");
    
    sb.append("    _123list: ").append(toIndentedString(_123list)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }
}

