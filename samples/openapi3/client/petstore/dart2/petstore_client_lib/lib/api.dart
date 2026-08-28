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

import 'model/api_response.dart';
import 'model/category.dart';
import 'model/order.dart';
import 'model/pet.dart';
import 'model/tag.dart';
import 'model/user.dart';

export 'model/api_response.dart';
export 'model/category.dart';
export 'model/order.dart';
export 'model/pet.dart';
export 'model/tag.dart';
export 'model/user.dart';


part 'api_client.dart';
part 'api_helper.dart';
part 'api_exception.dart';
part 'auth/authentication.dart';
part 'auth/api_key_auth.dart';
part 'auth/oauth.dart';
part 'auth/http_basic_auth.dart';
part 'auth/http_bearer_auth.dart';

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