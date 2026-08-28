//
// AUTO-GENERATED FILE, DO NOT MODIFY!
//
// @dart=2.18

// ignore_for_file: unused_element, unused_import
// ignore_for_file: always_put_required_named_parameters_first
// ignore_for_file: constant_identifier_names
// ignore_for_file: lines_longer_than_80_chars

library openapi.api;

import 'dart:async';
import 'dart:convert';
import 'dart:io';

import 'package:collection/collection.dart';
import 'package:http/http.dart';
import 'package:intl/intl.dart';
import 'package:meta/meta.dart';
import 'package:hive_ce/hive.dart';

export 'dart:async';
export 'dart:convert';
export 'dart:io';

export 'package:collection/collection.dart';
export 'package:http/http.dart';
export 'package:intl/intl.dart';
export 'package:meta/meta.dart';
export 'package:hive_ce/hive.dart';

import 'model/additional_properties_class.dart';
import 'model/all_of_with_single_ref.dart';
import 'model/animal.dart';
import 'model/api_response.dart';
import 'model/array_of_array_of_number_only.dart';
import 'model/array_of_number_only.dart';
import 'model/array_test.dart';
import 'model/capitalization.dart';
import 'model/cat.dart';
import 'model/category.dart';
import 'model/child_with_nullable.dart';
import 'model/class_model.dart';
import 'model/deprecated_object.dart';
import 'model/dog.dart';
import 'model/enum_arrays.dart';
import 'model/enum_class.dart';
import 'model/enum_test.dart';
import 'model/fake_big_decimal_map200_response.dart';
import 'model/file_schema_test_class.dart';
import 'model/foo.dart';
import 'model/foo_get_default_response.dart';
import 'model/format_test.dart';
import 'model/has_only_read_only.dart';
import 'model/health_check_result.dart';
import 'model/map_test.dart';
import 'model/mixed_properties_and_additional_properties_class.dart';
import 'model/model200_response.dart';
import 'model/model_client.dart';
import 'model/model_file.dart';
import 'model/model_list.dart';
import 'model/model_return.dart';
import 'model/name.dart';
import 'model/nullable_class.dart';
import 'model/number_only.dart';
import 'model/object_with_deprecated_fields.dart';
import 'model/order.dart';
import 'model/outer_composite.dart';
import 'model/outer_enum.dart';
import 'model/outer_enum_default_value.dart';
import 'model/outer_enum_integer.dart';
import 'model/outer_enum_integer_default_value.dart';
import 'model/outer_object_with_enum_property.dart';
import 'model/parent_with_nullable.dart';
import 'model/pet.dart';
import 'model/read_only_first.dart';
import 'model/single_ref_type.dart';
import 'model/special_model_name.dart';
import 'model/tag.dart';
import 'model/test_inline_freeform_additional_properties_request.dart';
import 'model/user.dart';

export 'model/additional_properties_class.dart';
export 'model/all_of_with_single_ref.dart';
export 'model/animal.dart';
export 'model/api_response.dart';
export 'model/array_of_array_of_number_only.dart';
export 'model/array_of_number_only.dart';
export 'model/array_test.dart';
export 'model/capitalization.dart';
export 'model/cat.dart';
export 'model/category.dart';
export 'model/child_with_nullable.dart';
export 'model/class_model.dart';
export 'model/deprecated_object.dart';
export 'model/dog.dart';
export 'model/enum_arrays.dart';
export 'model/enum_class.dart';
export 'model/enum_test.dart';
export 'model/fake_big_decimal_map200_response.dart';
export 'model/file_schema_test_class.dart';
export 'model/foo.dart';
export 'model/foo_get_default_response.dart';
export 'model/format_test.dart';
export 'model/has_only_read_only.dart';
export 'model/health_check_result.dart';
export 'model/map_test.dart';
export 'model/mixed_properties_and_additional_properties_class.dart';
export 'model/model200_response.dart';
export 'model/model_client.dart';
export 'model/model_file.dart';
export 'model/model_list.dart';
export 'model/model_return.dart';
export 'model/name.dart';
export 'model/nullable_class.dart';
export 'model/number_only.dart';
export 'model/object_with_deprecated_fields.dart';
export 'model/order.dart';
export 'model/outer_composite.dart';
export 'model/outer_enum.dart';
export 'model/outer_enum_default_value.dart';
export 'model/outer_enum_integer.dart';
export 'model/outer_enum_integer_default_value.dart';
export 'model/outer_object_with_enum_property.dart';
export 'model/parent_with_nullable.dart';
export 'model/pet.dart';
export 'model/read_only_first.dart';
export 'model/single_ref_type.dart';
export 'model/special_model_name.dart';
export 'model/tag.dart';
export 'model/test_inline_freeform_additional_properties_request.dart';
export 'model/user.dart';


part 'api_client.dart';
part 'api_helper.dart';
part 'api_exception.dart';
part 'auth/authentication.dart';
part 'auth/api_key_auth.dart';
part 'auth/oauth.dart';
part 'auth/http_basic_auth.dart';
part 'auth/http_bearer_auth.dart';

part 'api/another_fake_api.dart';
part 'api/default_api.dart';
part 'api/fake_api.dart';
part 'api/fake_classname_tags123_api.dart';
part 'api/pet_api.dart';
part 'api/store_api.dart';
part 'api/user_api.dart';


/// An [ApiClient] instance that uses the default values obtained from
/// the OpenAPI specification file.
var defaultApiClient = ApiClient();

const delimiters = {'csv': ',', 'ssv': ' ', 'tsv': '\t', 'pipes': '|'};
const dateEpochMarker = 'epoch';
const deepEquality = DeepCollectionEquality();
final dateFormatter = DateFormat('yyyy-MM-dd');
final regList = RegExp(r'^List<(.*)>$');
final regSet = RegExp(r'^Set<(.*)>$');
final regMap = RegExp(r'^Map<String,(.*)>$');

bool isEpochMarker(String? pattern) => pattern == dateEpochMarker || pattern == '/$dateEpochMarker/';

class HiveTypeIds {
  
}