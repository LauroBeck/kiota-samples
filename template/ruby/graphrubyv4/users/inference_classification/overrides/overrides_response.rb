require 'microsoft_kiota_abstractions'
require_relative '../../users'
require_relative '../inference_classification'
require_relative './overrides'

module Graphrubyv4::Users::InferenceClassification::Overrides
    class OverridesResponse
        include MicrosoftKiotaAbstractions::Parsable
        ## 
        # Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.
        @additional_data
        @next_link
        @value
        ## 
        ## Gets the AdditionalData property value. Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.
        ## @return a i_dictionary
        ## 
        def  additional_data
            return @additional_data
        end
        ## 
        ## Gets the nextLink property value. 
        ## @return a string
        ## 
        def  next_link
            return @next_link
        end
        ## 
        ## Gets the value property value. 
        ## @return a inference_classification_override
        ## 
        def  value
            return @value
        end
        ## 
        ## The deserialization information for the current model
        ## @return a i_dictionary
        ## 
        def get_field_deserializers() 
            return {
                "@odata.nextLink" => lambda {|o, n| o.next_link = n.get_object_value(string) },
                "value" => lambda {|o, n| o.value = n.get_collection_of_object_values(inference_classification_override) },
            }
        end
        ## 
        ## Serializes information the current object
        ## @param writer Serialization writer to use to serialize this model
        ## @return a void
        ## 
        def serialize(writer) 
            writer.write_object_value("@odata.nextLink", self.next_link)
            writer.write_collection_of_object_values("value", self.value)
            writer.write_additional_data(self.additional_data)
        end
        ## 
        ## Sets the AdditionalData property value. Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.
        ## @param value Value to set for the AdditionalData property.
        ## @return a void
        ## 
        def  additional_data=(additionalData)
            @additional_data = (additionalData)
        end
        ## 
        ## Sets the nextLink property value. 
        ## @param value Value to set for the nextLink property.
        ## @return a void
        ## 
        def  next_link=(nextLink)
            @next_link = (nextLink)
        end
        ## 
        ## Sets the value property value. 
        ## @param value Value to set for the value property.
        ## @return a void
        ## 
        def  value=(value)
            @value = (value)
        end
    end
end
